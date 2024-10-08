using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a request for a pet.
/// </summary>
public class Request : BaseEntity
{
    /// <summary>
    /// Foreign key to the user who created the request.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(AppUser))]
    public long AppUserId { get; set; }

    /// <summary>
    /// Title of the request.
    /// </summary>
    /// <example>I want a little cute kitty:)</example>
    [Required]
    [MaxLength(150)]
    public string Title { get; set; } = null!;


    #region Navigation properties

    /// <summary>
    /// Navigation property to the user who created the request.
    /// </summary>
    public AppUser? AppUser { get; set; }

    /// <summary>
    /// Collection of properties for the request.
    /// </summary>
    public ICollection<Property>? Properties { get; set; }

    #endregion
}