using AutoMapper;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Dtos.PropertyDtos;
using ItMarathon.Api.Dtos.ProposalDtos;
using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Entities;
using ItMarathon.Dal.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.OData.Query;

namespace ItMarathon.Api.Services;

/// <summary>
/// Service for managing proposals.
/// </summary>
/// <param name="unitOfWork">The unit of work managing repository's operations.</param>
/// <param name="mapper">The mapper instance for mapping objects.</param>
/// <param name="blobService">The service managing Azure Blob storage operations.</param>
public class ProposalService(IUnitOfWork unitOfWork, IMapper mapper, IAzureBlobService blobService) : IProposalService
{
    /// <inheritdoc/>
    public async Task<IQueryable<ProposalDto>> GetAllProposalsAsync()
    {
        var proposals = await unitOfWork.Proposals.GetProposalsAsync(false);
        return mapper.ProjectTo<ProposalDto>(proposals);
    }

    /// <inheritdoc/>
    public async Task<ProposalDto> GetProposalByIdAsync(long id)
    {
        var proposal = await unitOfWork.Proposals.GetProposalAsync(id, false);

        return mapper.Map<ProposalDto>(proposal);
    }

    /// <inheritdoc/>
    public async Task<ProposalDto> CreateProposalAsync(CreateProposalDto proposalDto, long userId)
    {
        var proposal = mapper.Map<Proposal>(proposalDto);
        proposal.AppUserId = userId;

        if (proposalDto.Photos is not null)
        {
            proposal.Photos = Array.Empty<ProposalPhoto>();

            foreach (var photoDto in proposalDto.Photos)
            {
                var imageUrl = await blobService.UploadImageAsync(photoDto.Image);
                proposal.Photos
                    .Add(new ProposalPhoto { Url = imageUrl, CreatedOn = DateTime.UtcNow });
            }
        }

        unitOfWork.Proposals.CreateProposal(proposal);
        await unitOfWork.SaveChangesAsync();
        var newProposal = await unitOfWork.Proposals
            .GetProposalAsync(proposal.Id, false);

        return mapper.Map<ProposalDto>(newProposal);
    }

    /// <inheritdoc/>
    public async Task<Proposal?> DeleteProposalAsync(long id)
    {
        var proposal = await unitOfWork.Proposals.GetProposalAsync(id, true);

        if (proposal is null)
        {
            return null;
        }

        unitOfWork.Proposals.DeleteProposal(proposal!);
        await unitOfWork.SaveChangesAsync();

        if (proposal!.Photos is not null)
        {
            foreach (var photo in proposal.Photos)
            {
                await blobService.DeleteImageAsync(photo.Url);
            }
        }

        return proposal;
    }

    /// <inheritdoc/>
    public async Task<ProposalDto?> UpdateProposalAsync(long id, UpdateProposalDto proposalDto)
    {
        var existingDbProposal = await unitOfWork.Proposals.GetProposalAsync(id, true);

        if (existingDbProposal is null)
        {
            return null;
        }

        mapper.Map(proposalDto, existingDbProposal);
        var proposalsProperties = await unitOfWork.Properties
            .GetPropertyByProposalAsync(existingDbProposal!.Id, true);

        foreach (var property in proposalsProperties)
        {
            if (!proposalDto.Properties!.Any(p => p.Id == property.Id))
            {
                unitOfWork.Properties.DeleteProperty(property);
            }
        }

        foreach (var propertyDto in proposalDto.Properties!)
        {
            var existingProperty = proposalsProperties
                .FirstOrDefault(p => p.Id == propertyDto.Id);

            if (existingProperty is not null)
            {
                mapper.Map(propertyDto, existingProperty);
            }
            else
            {
                var newProperty = mapper.Map<Property>(propertyDto);
                newProperty.CreatedOn = DateTime.UtcNow;
                existingDbProposal.Properties!.Add(newProperty);
            }
        }

        foreach (var existingDbPhoto in existingDbProposal.Photos!)
        {
            var photoDto = proposalDto.Photos!
                .FirstOrDefault(p => p.Id == existingDbPhoto.Id);

            if (photoDto is null)
            {
                await blobService.DeleteImageAsync(existingDbPhoto.Url);
                unitOfWork.ProposalPhotos.DeleteProposalPhoto(existingDbPhoto);

            }
            else if (photoDto.Image is not null)
            {
                await blobService.DeleteImageAsync(existingDbPhoto.Url);
                existingDbPhoto.Url = await blobService.UploadImageAsync(photoDto.Image);
                existingDbPhoto.LastModifiedOn = DateTime.UtcNow;
            }
        }

        foreach (var photoDto in proposalDto.Photos!.Where(p => p.Id == 0))
        {
            var imageUrl = await blobService.UploadImageAsync(photoDto.Image!);
            existingDbProposal.Photos
                .Add(new ProposalPhoto { Url = imageUrl, CreatedOn = DateTime.UtcNow });
        }

        unitOfWork.Proposals.Update(existingDbProposal);
        await unitOfWork.SaveChangesAsync();
        var updatedProposal = await unitOfWork
            .Proposals.GetProposalAsync(existingDbProposal.Id, false);

        return mapper.Map<ProposalDto>(updatedProposal);
    }

    /// <inheritdoc/>
    public async Task ValidateMandatoryPropertyDefinitions(HashSet<long> propertyDefinitionIds, ModelStateDictionary modelState)
    {
        var mandatoryPropertyDefinitions = await unitOfWork.PropertyDefinitions.GetMandatoryPropertyDefinitionsAsync(false);

        var mandatoryPropertyDefinitionsDict = mandatoryPropertyDefinitions
            .ToDictionary(pd => pd.Id, pd => pd.Name);

        var missingMandatoryPropertyDefinitions = mandatoryPropertyDefinitionsDict
            .Where(pair => !propertyDefinitionIds.Contains(pair.Key)).ToList();

        if (missingMandatoryPropertyDefinitions.Count != 0)
        {
            var missingDetails = string.Join(", ", missingMandatoryPropertyDefinitions
             .Select(pair => $"{{Id: {pair.Key}, Name: {pair.Value}}}"));

            modelState.AddModelError("Property", $"Mandatory properties are missing: {missingDetails}");
        }
    }

    /// <inheritdoc/>
    public async Task ValidatePropertiesAsync<T>(ICollection<T> propertyDtos, ModelStateDictionary modelState)
        where T : CreatePropertyDto
    {
        ValidatePropertyDefinitionDuplications(propertyDtos, modelState);

        foreach (var property in propertyDtos)
        {
            var propertyDefinition = await unitOfWork.PropertyDefinitions
                .GetPropertyDefinitionAsync(property.PropertyDefinitionId, false);

            if (propertyDefinition is null)
            {
                modelState
                    .AddModelError("Property Definition", $"Invalid property definition with Id - {property.PropertyDefinitionId}.");
                return;
            }

            switch (propertyDefinition!.PropertyDefinitionType)
            {
                case PropertyDefinitionType.Custom:
                    ValidateCustomPropertyDefinition(property, modelState);
                    break;

                case PropertyDefinitionType.Predefined:
                    var predefinedValueIds = propertyDtos
                        .Select(p => p.PredefinedValueId)
                        .ToArray();
                    await ValidatePredefinedPropertyDefinitionAsync(propertyDefinition, predefinedValueIds, property, modelState);
                    break;

                default:
                    modelState
                        .AddModelError("Property Definition Type", "Invalid property definition type.");
                    break;
            }
        }
    }

    private static void ValidateCustomPropertyDefinition(CreatePropertyDto property, ModelStateDictionary modelState)
    {
        if (string.IsNullOrEmpty(property.CustomValue) && property.PredefinedValueId.HasValue)
        {
            modelState
                .AddModelError("Property", $"Custom property Id: {property.PropertyDefinitionId}," +
                $" must have only a custom value, and doesn't contain predefined value.");
        }
    }

    private async Task ValidatePredefinedPropertyDefinitionAsync(
        PropertyDefinition propertyDefinition,
        long?[] predefinedValueIds,
        CreatePropertyDto property,
        ModelStateDictionary modelState)
    {
        if (!property.PredefinedValueId.HasValue)
        {
            modelState
                .AddModelError("Predefined value", $"Invalid predefined value in property definition Id - {propertyDefinition.Id}.");
            return;
        }

        var predefinedValue = await unitOfWork.PropertyValues
            .GetPropertyValueAsync(property.PredefinedValueId.Value, false);

        if (!string.IsNullOrEmpty(property.CustomValue))
        {
            modelState
                .AddModelError("Property", $"Predefined property Id: {property.PropertyDefinitionId}, cannot have custom value: {property.CustomValue}.");
        }
        else if (property.PredefinedValueId.HasValue
            && !propertyDefinition.PropertyValues!.Any(pv => pv.Id == property.PredefinedValueId))
        {
            modelState
                .AddModelError("Property", $"Invalid predefined value Id: {property.PredefinedValueId}, for property definition Id: {propertyDefinition.Id}.");
        }
        else if (predefinedValue!.ParentId.HasValue && !await CheckParentValueConsistencyAsync(predefinedValue, predefinedValueIds))
        {
            modelState
                .AddModelError("Property", $"Invalid predefined value Id: {predefinedValue.Id}, for property definition id: {propertyDefinition.Id}");
        }
    }

    private async Task<bool> CheckParentValueConsistencyAsync(PropertyValue predefinedValue, long?[] predefinedValueIds)
    {
        if (!predefinedValue.ParentId.HasValue)
        {
            return true;
        }

        var parentValue = await unitOfWork.PropertyValues
            .GetPropertyValueAsync(predefinedValue.ParentId.Value, false);

        if (parentValue is null)
        {
            return false;
        }

        return predefinedValueIds.Contains(parentValue.Id);
    }

    private static void ValidatePropertyDefinitionDuplications(IEnumerable<CreatePropertyDto> properties, ModelStateDictionary modelState)
    {
        var duplicateGroups = properties
            .GroupBy(p => p.PropertyDefinitionId)
            .Where(g => g.Count() > 1)
            .ToList();

        if (duplicateGroups.Count != 0)
        {
            var duplicates = string.Join(", ", duplicateGroups.Select(g => g.Key));
            modelState.AddModelError("Properties", $"Cannot add the same properies with id: {duplicates}");
        }
    }
}
