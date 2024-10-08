using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing Property entities in the repository.
/// </summary>
public interface IPropertyRepository
{
    /// <summary>
    /// Retrieves all Property entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of Property entities.</returns>
    Task<IEnumerable<Property>> GetAllPropertiesAsync(bool trackChanges);

    /// <summary>
    /// Retrieves a Property entity by its ID.
    /// </summary>
    /// <param name="propertyId">The ID of the property.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The Property entity, or null if not found.</returns>
    Task<Property?> GetPropertyAsync(long propertyId, bool trackChanges);

    /// <summary>
    /// Retrieves Property entities associated with a specific proposal.
    /// </summary>
    /// <param name="proposalId">The ID of the proposal.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of Property entities associated with the proposal.</returns>
    Task<IEnumerable<Property>> GetPropertyByProposalAsync(long proposalId, bool trackChanges);

    /// <summary>
    /// Creates a new Property entity.
    /// </summary>
    /// <param name="property">The Property entity.</param>
    void CreateProperty(Property property);

    /// <summary>
    /// Deletes a Property entity.
    /// </summary>
    /// <param name="property">The Property entity.</param>
    void DeleteProperty(Property property);
}