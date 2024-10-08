namespace ItMarathon.Dal.Entities;

/// <summary>
/// Base entity class for all entities in the system.
/// </summary>
public abstract class BaseEntity
{
    /// <summary>
    /// Unique identifier for the entity.
    /// </summary>
    /// <example>1</example>
    public long Id { get; set; }

    /// <summary>
    /// Date and time when the entity was created.
    /// </summary>
    /// <example>2023-10-26T15:00:00Z</example>
    public DateTime CreatedOn { get; set; }

    /// <summary>
    /// Date and time when the entity was last modified.
    /// </summary>
    /// <example>2023-10-27T10:30:00Z</example>
    public DateTime? LastModifiedOn { get; set; }
}
