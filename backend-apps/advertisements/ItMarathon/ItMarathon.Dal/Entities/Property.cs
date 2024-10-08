using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a property of a proposal or request.
/// </summary>
public class Property : BaseEntity
{
    /// <summary>
    /// Foreign key to the property definition.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(PropertyDefinition))]
    public long PropertyDefinitionId { get; set; }

    /// <summary>
    /// Foreign key to the predefined value.
    /// </summary>
    /// <example>2</example>
    [ForeignKey(nameof(PredefinedValue))]
    public long? PredefinedValueId { get; set; }

    /// <summary>
    /// Custom value for the property.
    /// </summary>
    /// <example>My custom value</example>
    [MaxLength(100)]
    public string? CustomValue { get; set; }

    /// <summary>
    /// Foreign key to the proposal.
    /// </summary>
    /// <example>3</example>
    [ForeignKey(nameof(Proposal))]
    public long? ProposalId { get; set; }

    /// <summary>
    /// Foreign key to the request.
    /// </summary>
    /// <example>4</example>
    [ForeignKey(nameof(Request))]
    public long? RequestId { get; set; }


    #region Navigation properties

    /// <summary>
    /// Navigation property to the property definition.
    /// </summary>
    public PropertyDefinition? PropertyDefinition { get; set; }

    /// <summary>
    /// Navigation property to the predefined value.
    /// </summary>
    public PropertyValue? PredefinedValue { get; set; }

    /// <summary>
    /// Navigation property to the proposal.
    /// </summary>
    public Proposal? Proposal { get; set; }

    /// <summary>
    /// Navigation property to the request.
    /// </summary>
    public Request? Request { get; set; }

    #endregion
}