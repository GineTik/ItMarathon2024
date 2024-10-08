using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a predefined value for a property definition.
/// </summary>
public class PropertyValue : BaseEntity
{
    /// <summary>
    /// Foreign key to the property definition.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(PropertyDefinition))]
    public long PropertyDefinitionId { get; set; }

    /// <summary>
    /// Value of the predefined value.
    /// </summary>
    /// <example>My predefined value</example>
    [Required]
    [MaxLength(100)]
    public string Value { get; set; } = null!;

    [ForeignKey(nameof(ParentPropertyValue))]
    public long? ParentId { get; set; }

    #region Navigation properties

    /// <summary>
    /// Navigation property to the property definition.
    /// </summary>
    public PropertyDefinition? PropertyDefinition { get; set; }

    /// <summary>
    /// Navigation property to the property that uses this predefined value.
    /// </summary>
    public Property? Property { get; set; }

    /// <summary>
    /// Navigation property to the parent property value, if this value is a child of another property value.
    /// </summary>
    [DeleteBehavior(DeleteBehavior.SetNull)]
    public PropertyValue? ParentPropertyValue { get; set; }

    #endregion
}