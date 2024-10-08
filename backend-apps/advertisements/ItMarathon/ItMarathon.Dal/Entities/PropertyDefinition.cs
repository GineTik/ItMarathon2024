using ItMarathon.Dal.Enums;
using System.ComponentModel.DataAnnotations;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a definition of a property for a proposal or request.
/// </summary>
public class PropertyDefinition : BaseEntity
{
    /// <summary>
    /// Name of the property definition.
    /// </summary>
    /// <example>Property Name</example>
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type of the property definition.
    /// </summary>
    /// <example>Predefined</example>
    /// <example>Custom</example>
    public PropertyDefinitionType PropertyDefinitionType { get; set; }

    /// <summary>
    /// Indicates whether the property is mandatory.
    /// </summary>
    /// <remarks>
    /// A mandatory property must have a value assigned to it.
    /// </remarks>
    public bool IsMandatory { get; set; }

    /// <summary>
    /// Category of the property definition.
    /// </summary>
    [MaxLength(50)]
    public string? Category { get; set; }

    #region Navigation properties

    /// <summary>
    /// Collection of predefined values for the property definition.
    /// </summary>
    public ICollection<PropertyValue>? PropertyValues { get; set; }

    /// <summary>
    /// Collection of properties that use this property definition.
    /// </summary>
    public ICollection<Property>? Properties { get; set; }

    #endregion
}