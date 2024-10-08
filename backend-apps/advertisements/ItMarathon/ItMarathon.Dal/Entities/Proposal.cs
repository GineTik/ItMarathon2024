using ItMarathon.Dal.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItMarathon.Dal.Entities;

/// <summary>
/// Represents a proposal for a pet.
/// </summary>
public class Proposal : BaseEntity
{
    /// <summary>
    /// Foreign key to the user who created the proposal.
    /// </summary>
    /// <example>1</example>
    [ForeignKey(nameof(AppUser))]
    public long AppUserId { get; set; }

    /// <summary>
    /// Title of the proposal.
    /// </summary>
    /// <example>My amazing proposal</example>
    [Required]
    [MaxLength(150)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Name of the pet.
    /// </summary>
    /// <example>Fluffy</example>
    [MaxLength(50)]
    public string? PetName { get; set; }

    /// <summary>
    /// Price of the pet.
    /// </summary>
    /// <example>150.00</example>
    [Required]
    public decimal Price { get; set; }

    /// <summary>
    /// Summary of the proposal.
    /// </summary>
    /// <example>This is a great pet and you should buy it.</example>
    [MaxLength(1500)]
    public string? Summary { get; set; }

    /// <summary>
    /// Location of the pet.
    /// </summary>
    /// <example>New York, NY</example>
    [Required]
    [MaxLength(50)]
    public string Location { get; set; } = null!;

    /// <summary>
    /// Indicates whether the proposal is active or not.
    /// </summary>
    /// <example>false</example>
    public bool IsActive { get; set; } = true;

    /// <summary>
    /// Age of the pet.
    /// </summary>
    /// <example>10</example>
    public int Age { get; set; }

    /// <summary>
    /// Age units of the pet.
    /// </summary>
    /// <example>10</example>
    public int AgeUnits { get; set; }

    /// <summary>
    /// The origin of the pet.
    /// </summary>
    /// <example>1</example>
    /// <remarks>
    /// The origin of the pet can be one of the following:
    /// - 1: The pet is from an animal shelter.
    /// - 2: The pet is from a registered breeder.
    /// - 3: The pet is owned by a private individual.
    /// </remarks>
    public PetOrigin PetOrigin { get; set; } = PetOrigin.PrivateIndividual;


    #region Navigation properties

    /// <summary>
    /// Navigation property to the user who created the proposal.
    /// </summary>
    public AppUser? AppUser { get; set; }

    /// <summary>
    /// Collection of photos for the proposal.
    /// </summary>
    public ICollection<ProposalPhoto>? Photos { get; set; }

    /// <summary>
    /// Collection of properties for the proposal.
    /// </summary>
    public ICollection<Property>? Properties { get; set; }

    #endregion
}