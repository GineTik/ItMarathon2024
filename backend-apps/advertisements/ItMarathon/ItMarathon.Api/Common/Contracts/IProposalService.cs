using ItMarathon.Api.Dtos.PropertyDtos;
using ItMarathon.Api.Dtos.ProposalDtos;
using ItMarathon.Dal.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.OData.Query;

namespace ItMarathon.Api.Common.Contracts;

/// <summary>
/// Provides functionality to interact with Proposals.
/// </summary>
public interface IProposalService
{
    /// <summary>
    /// Retrieves list of proposals.
    /// </summary>
    /// <returns>A task that contains a page of proposals.</returns>
    Task<IQueryable<ProposalDto>> GetAllProposalsAsync();

    /// <summary>
    /// Retrieves a specific proposal by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the proposal.</param>
    /// <returns>A task that returns the requested proposal.</returns>
    Task<ProposalDto> GetProposalByIdAsync(long id);

    /// <summary>
    /// Creates a new proposal based on the provided data transfer object.
    /// </summary>
    /// <param name="proposalDto">The data transfer object containing
    /// the necessary data to create a proposal.</param>
    /// <param name="userId">The identifier of the user
    /// that creates a proposal</param>
    /// <returns>A task that returns the newly created proposal.</returns>
    Task<ProposalDto> CreateProposalAsync(CreateProposalDto proposalDto, long userId);

    /// <summary>
    /// Updates an existing proposal with data from a provided data transfer object.
    /// </summary>
    /// <param name="id">The unique identifier of the proposal to update.</param>
    /// <param name="proposalDto">The data transfer object
    /// containing the updated data for the proposal.</param>
    /// <returns>A task that returns the updated proposal.</returns>
    Task<ProposalDto?> UpdateProposalAsync(long id, UpdateProposalDto proposalDto);

    /// <summary>
    /// Deletes a proposal by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the proposal to be deleted.</param>
    /// <returns>A task that returns the deleted proposal entity.</returns>
    Task<Proposal?> DeleteProposalAsync(long id);

    /// <summary>
    /// Validates whether all mandatory property definitions are present in the provided set of property definition IDs.
    /// Adds an error to the <see cref="ModelStateDictionary"/> if any mandatory property definitions are missing.
    /// </summary>
    /// <param name="propertyDefinitionIds">
    /// A <see cref="HashSet{T}"/> of property definition IDs to validate. 
    /// The IDs in this set are compared against the mandatory property definitions to ensure all required properties are included.
    /// </param>
    /// <param name="modelState">
    /// An instance of <see cref="ModelStateDictionary"/> where validation errors are added if mandatory property definitions are missing.
    /// This parameter is used to record any validation issues encountered during the check.
    /// </param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task ValidateMandatoryPropertyDefinitions(HashSet<long> propertyDefinitionIds, ModelStateDictionary modelState);

    /// <summary>
    /// Validates a collection of properties.
    /// </summary>
    /// <typeparam name="T">A type that inherits from <see cref="CreatePropertyDto"/></typeparam>
    /// <param name="propertyDtos">The collection of properties to validate.</param>
    /// <param name="modelState">
    /// An instance of <see cref="ModelStateDictionary"/> where validation errors are added if mandatory property definitions are missing.
    /// This parameter is used to record any validation issues encountered during the check.
    /// </param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task ValidatePropertiesAsync<T>(ICollection<T> propertyDtos, ModelStateDictionary modelState) where T : CreatePropertyDto;
}
