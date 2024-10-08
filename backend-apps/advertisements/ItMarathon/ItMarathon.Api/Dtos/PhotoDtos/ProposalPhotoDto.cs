using System.ComponentModel.DataAnnotations;
using Base64StringAttribute = ItMarathon.Api.Common.Validators.Base64StringAttribute;

namespace ItMarathon.Api.Dtos.PhotoDtos
{
    /// <summary>
    /// Represents a data transfer object for a photo associated with a proposal.
    /// </summary>
    public class ProposalPhotoDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the photo.
        /// </summary>
        [Range(0, long.MaxValue)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the URL of the photo.
        /// This field is required and must be a valid URL format.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// Gets or sets the Base64 encoded string of the image to be added to a proposal.
        /// </summary>
        [Base64String(true)]
        public string? Image { get; set; }
    }
}
