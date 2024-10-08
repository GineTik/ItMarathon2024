using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents an access token associated with a user.
/// </summary>
[Table("access_tokens")]
[Index(nameof(UserId), Name = "fk_access_tokens_user_id_users", IsUnique = false)]
[Index(nameof(CreatedAt), Name = "ix_access_tokens_created_at", IsUnique = false)]
public class AccessToken
{
    /// <summary>
    /// Foreign key referencing the User ID who owns the access token.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(User))]
    [Column("user_id")]
    public long UserId { get; set; }

    /// <summary>
    /// Access token string, used for authentication.
    /// </summary>
    /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
    [Key]
    [MaxLength(43)]
    [Column("token")]
    public string Token { get; set; } = null!;

    /// <summary>
    /// Timestamp indicating when the access token was created.
    /// </summary>
    /// <example>2023-10-26T13:00:00Z</example>
    [Required]
    [Column("created_at", TypeName = "timestamp")]
    public DateTime CreatedAt { get; set; }


    #region Navigation properties

    /// <summary>
    /// Navigation property representing the AppUser who owns this access token.
    /// </summary>
    public AppUser User { get; set; } = null!;

    #endregion
}