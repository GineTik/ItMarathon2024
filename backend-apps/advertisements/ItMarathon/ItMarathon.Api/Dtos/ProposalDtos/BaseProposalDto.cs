using ItMarathon.Dal.Enums;
using System.ComponentModel.DataAnnotations;

namespace ItMarathon.Api.Dtos.ProposalDtos
{
    /// <summary>
    /// Base data transfer object for other proposal dtos.
    /// </summary>
    public class BaseProposalDto
    {
        /// <summary>
        /// Gets or sets a value indicating whether the proposal is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the origin of the pet in the proposal.
        /// </summary>
        [EnumDataType(typeof(PetOrigin))]
        public PetOrigin PetOrigin { get; set; }

        /// <summary>
        /// Gets or sets the title of the proposal.
        /// </summary>
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(150, ErrorMessage = "Title cannot exceed 150 characters.")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        public string Title { get; set; } = null!;

        /// <summary>
        /// Gets or sets the name of the pet in the proposal.
        /// </summary>
        [MaxLength(50, ErrorMessage = "Pet name cannot exceed 50 characters.")]
        public string? PetName { get; set; }

        /// <summary>
        /// Gets or sets the price of the pet in the proposal.
        /// </summary>
        [Required]
        [Range(typeof(decimal), "0", "999999", ErrorMessage = "Price must be between 0 and 999,999.")]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the summary of the proposal.
        /// </summary>
        [MaxLength(1500, ErrorMessage = "Summary cannot exceed 1500 characters.")]
        public string? Summary { get; set; }

        /// <summary>
        /// Gets or sets the location where the pet is available.
        /// </summary>
        [Required]
        [MaxLength(50, ErrorMessage = "Location cannot exceed 50 characters.")]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Gets or sets the age of the pet.
        /// </summary>
        [Required]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the age units of the pet.
        /// </summary>
        [Required]
        public int AgeUnits { get; set; }
    }
}