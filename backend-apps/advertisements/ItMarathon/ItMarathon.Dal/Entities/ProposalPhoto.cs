using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a photo for a proposal.
/// </summary>
public class ProposalPhoto : BaseEntity
{
    /// <summary>
    /// Foreign key to the proposal.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(Proposal))]
    public long ProposalId { get; set; }

    /// <summary>
    /// URL of the photo.
    /// </summary>
    [Required]
    [MaxLength(2048)]
    public string Url { get; set; } = null!;


    #region Navigation properties

    /// <summary>
    /// Navigation property to the proposal.
    /// </summary>
    public Proposal? Proposal { get; set; }

    #endregion
}