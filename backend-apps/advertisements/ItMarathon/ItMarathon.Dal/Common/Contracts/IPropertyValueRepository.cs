using ItMarathon.Dal.Entities;

namespace ItMarathon.Dal.Common.Contracts;

/// <summary>
/// Interface for managing PropertyValue entities in the repository.
/// </summary>
public interface IPropertyValueRepository
{
    /// <summary>
    /// Retrieves all PropertyValue entities.
    /// </summary>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>Collection of PropertyValue entities.</returns>
    Task<IEnumerable<PropertyValue>> GetAllPropertyValuesAsync(bool trackChanges);

    /// <summary>
    /// Retrieves a PropertyValue entity by its ID.
    /// </summary>
    /// <param name="propertyValueId">The ID of the property value.</param>
    /// <param name="trackChanges">Indicates whether to track changes in the Entity Framework context.</param>
    /// <returns>The PropertyValue entity, or null if not found.</returns>
    Task<PropertyValue?> GetPropertyValueAsync(long propertyValueId, bool trackChanges);

    /// <summary>
    /// Creates a new PropertyValue entity.
    /// </summary>
    /// <param name="propertyValue">The PropertyValue entity.</param>
    void CreatePropertyValue(PropertyValue propertyValue);

    /// <summary>
    /// Deletes a PropertyValue entity.
    /// </summary>
    /// <param name="propertyValue">The PropertyValue entity.</param>
    void DeletePropertyValue(PropertyValue propertyValue);
}