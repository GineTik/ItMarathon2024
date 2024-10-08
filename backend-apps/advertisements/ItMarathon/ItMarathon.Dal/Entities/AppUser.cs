using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents an user of the application.
/// </summary>
[Table("users")]
[Index(nameof(Email), Name = "ix_users_email", IsUnique = true)]
public class AppUser
{
    /// <summary>
    /// Unique identifier for the user.
    /// </summary>
    /// <example>1</example>
    [Column("id")]
    public long Id { get; set; }

    /// <summary>
    /// User's email address.
    /// </summary>
    /// <example>john.doe@example.com</example>
    [Required]
    [EmailAddress]
    [MaxLength(320)]
    [Column("email")]
    public string Email { get; set; } = null!;

    /// <summary>
    /// User's hashed password.
    /// </summary>
    [Required]
    [MaxLength(1024)]
    [Column("hashed_password")]
    public string HashedPassword { get; set; } = null!;

    /// <summary>
    /// Indicates whether the user's account is active.
    /// </summary>
    /// <example>true</example>
    [Required]
    [Column("is_active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// Indicates whether the user has superuser privileges.
    /// </summary>
    /// <example>false</example>
    [Required]
    [Column("is_superuser")]
    public bool IsSuperuser { get; set; }

    /// <summary>
    /// Indicates whether the user's email address has been verified.
    /// </summary>
    /// <example>true</example>
    [Required]
    [Column("is_verified")]
    public bool IsVerified { get; set; }

    /// <summary>
    /// User's name.
    /// </summary>
    /// <example>John</example>
    [Required]
    [MaxLength(50)]
    [Column("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// User's surname.
    /// </summary>
    /// <example>Doe</example>
    [Required]
    [MaxLength(50)]
    [Column("surname")]
    public string Surname { get; set; } = null!;

    /// <summary>
    /// User's phone number.
    /// </summary>
    /// <example>+38 (063) 433 33 33</example>
    [Phone]
    [MaxLength(15)]
    [Column("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// Date and time when the user account was created.
    /// </summary>
    /// <example>2023-10-26T10:00:00Z</example>
    [Required]
    [Column("created_on", TypeName = "datetime")]
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Date and time when the user account was last modified.
    /// </summary>
    /// <example>2023-10-26T12:34:56Z</example>
    [Required]
    [Column("last_modified_on", TypeName = "datetime")]
    public DateTime LastModifiedOn { get; set; }

    /// <summary>
    /// User's location.
    /// </summary>
    /// <example>New York, USA</example>
    [Required]
    [MaxLength(120)]
    [Column("location")]
    public string Location { get; set; } = null!;

    /// <summary>
    /// Indicates whether the user prefers to be contacted via phone call.
    /// </summary>
    /// <example>true</example>
    [Required]
    [Column("prefers_phone_call")]
    public bool PrefersPhoneCall { get; set; }

    /// <summary>
    /// Indicates whether the user prefers to be contacted via Telegram.
    /// </summary>
    /// <example>false</example>
    [Required]
    [Column("prefers_telegram")]
    public bool PrefersTelegram { get; set; }


    #region Navigation properties

    /// <summary>
    /// AccessTokens of the user.
    /// </summary>
    public ICollection<AccessToken>? AccessTokens { get; set; }

    /// <summary>
    /// Proposals created by the user.
    /// </summary>
    public ICollection<Proposal>? Proposals { get; set; }

    /// <summary>
    /// Requests created by the user.
    /// </summary>
    public ICollection<Request>? Requests { get; set; }

    #endregion
}