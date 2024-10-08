using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing PropertyDefinition entities in the repository.
/// </summary>
public interface IPropertyDefinitionRepository : IRepositoryBase<PropertyDefinition>
{
    /// <summary>
    /// Retrieves all PropertyDefinition entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of PropertyDefinition entities.</returns>
    Task<IEnumerable<PropertyDefinition>> GetAllPropertyDefinitionsAsync(bool trackChanges);

    /// <summary>
    /// Retrieves a PropertyDefinition entity by its ID.
    /// </summary>
    /// <param name="propertyDefinitionId">The ID of the property definition.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The PropertyDefinition entity, or null if not found.</returns>
    Task<PropertyDefinition?> GetPropertyDefinitionAsync(long propertyDefinitionId, bool trackChanges);

    /// <summary>
    /// Creates a new PropertyDefinition entity.
    /// </summary>
    /// <param name="propertyDefinition">The PropertyDefinition entity.</param>
    void CreatePropertyDefinition(PropertyDefinition propertyDefinition);

    /// <summary>
    /// Deletes a PropertyDefinition entity.
    /// </summary>
    /// <param name="propertyDefinition">The PropertyDefinition entity.</param>
    void DeletePropertyDefinition(PropertyDefinition propertyDefinition);

    /// <summary>
    /// Retrieves all PropertyDefinition entities that are marked as mandatory.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of PropertyDefinition entities.</returns>
    Task<IEnumerable<PropertyDefinition>> GetMandatoryPropertyDefinitionsAsync(bool trackChanges);
}