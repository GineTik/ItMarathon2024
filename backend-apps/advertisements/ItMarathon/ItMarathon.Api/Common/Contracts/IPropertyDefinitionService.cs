using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Common.Contracts;

/// <summary>
/// Provides functionality to interact with Property Definitions.
/// </summary>
public interface IPropertyDefinitionService
{
    /// <summary>
    /// Retrieves all property definitions.
    /// </summary>
    /// <returns>A task that contains a collection of property definitions.</returns>
    Task<IEnumerable<PropertyDefinitionDto>> GetPropertyDefinitionsAsync();

    /// <summary>
    /// Retrieves a specific property definition by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the property definition to retrieve.</param>
    /// <returns>A task that contains the property definition.</returns>
    Task<PropertyDefinitionDto> GetPropertyDefinitionByIdAsync(long id);

    /// <summary>
    /// Creates a new property definition based on the provided data transfer object.
    /// </summary>
    /// <param name="propertyDefinition">The data transfer object containing
    /// the new property definition data.</param>
    /// <returns>A task that contains the newly created property definition.</returns>
    Task<PropertyDefinitionDto> CreatePropertyDefinitionAsync(CreatePropertyDefinitionDto propertyDefinition);

    /// <summary>
    /// Updates an existing property definition with the new data provided
    /// in the data transfer object.
    /// </summary>
    /// <param name="id">The unique identifier of the property definition to update.</param>
    /// <param name="propertyDefinition">The data transfer object
    /// containing updated data for the property definition.</param>
    /// <returns>A task that contains the updated property definition.</returns>
    Task<PropertyDefinitionDto?> UpdatePropertyDefinitionAsync(long id, UpdatePropertyDefinitionDto propertyDefinition);

    /// <summary>
    /// Deletes a property definition identified by its unique identifier.
    /// </summary>
    /// <param name="id">The unique identifier of the property definition to be deleted.</param>
    /// <returns>A task that contains the deleted property definition.</returns>
    Task<PropertyDefinition?> DeletePropertyDefinitionAsync(long id);
}
