using AutoMapper;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Services;

/// <summary>
/// Service for managing property definitions.
/// </summary>
/// <param name="unitOfWork">The unit of work managing repository's operations..</param>
/// <param name="mapper">The mapper instance for mapping objects.</param>
public class PropertyDefinitionService(IUnitOfWork unitOfWork, IMapper mapper) : IPropertyDefinitionService
{
    /// <inheritdoc/>
    public async Task<IEnumerable<PropertyDefinitionDto>> GetPropertyDefinitionsAsync()
    {
        var propertyDefinitions = await unitOfWork.PropertyDefinitions
            .GetAllPropertyDefinitionsAsync(false);

        return mapper.Map<IEnumerable<PropertyDefinitionDto>>(propertyDefinitions);
    }

    /// <inheritdoc/>
    public async Task<PropertyDefinitionDto> GetPropertyDefinitionByIdAsync(long id)
    {
        var propertyDefinition = await unitOfWork.PropertyDefinitions
            .GetPropertyDefinitionAsync(id, false);

        return mapper.Map<PropertyDefinitionDto>(propertyDefinition);
    }

    /// <inheritdoc/>
    public async Task<PropertyDefinitionDto> CreatePropertyDefinitionAsync(CreatePropertyDefinitionDto propertyDefinition)
    {
        var propertyDefinitionEntity = mapper
            .Map<PropertyDefinition>(propertyDefinition);
        unitOfWork.PropertyDefinitions
            .CreatePropertyDefinition(propertyDefinitionEntity);
        await unitOfWork.SaveChangesAsync();

        return mapper.Map<PropertyDefinitionDto>(propertyDefinitionEntity);
    }

    /// <inheritdoc/>
    public async Task<PropertyDefinition?> DeletePropertyDefinitionAsync(long id)
    {
        var propertyDefinition = await unitOfWork.PropertyDefinitions
            .GetPropertyDefinitionAsync(id, false);

        if (propertyDefinition is null)
        {
            return null;
        }

        unitOfWork.PropertyDefinitions.DeletePropertyDefinition(propertyDefinition);
        await unitOfWork.SaveChangesAsync();

        return propertyDefinition;
    }

    /// <inheritdoc/>
    public async Task<PropertyDefinitionDto?> UpdatePropertyDefinitionAsync(long id, UpdatePropertyDefinitionDto propertyDefinition)
    {
        var existingPropertyDefinition = await unitOfWork.PropertyDefinitions
            .GetPropertyDefinitionAsync(id, true);

        if (existingPropertyDefinition is null)
        {
            return null;
        }

        mapper.Map(propertyDefinition, existingPropertyDefinition);
        unitOfWork.PropertyDefinitions.Update(existingPropertyDefinition);
        await unitOfWork.SaveChangesAsync();

        return mapper.Map<PropertyDefinitionDto>(existingPropertyDefinition);
    }
}
