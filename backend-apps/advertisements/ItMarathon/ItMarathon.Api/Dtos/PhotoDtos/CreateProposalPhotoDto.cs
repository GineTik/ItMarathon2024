using ItMarathon.Api.Common.Validators;

namespace ItMarathon.Api.Dtos.PhotoDtos
{
    /// <summary>
    /// Represents the data transfer object for creating a proposal photo.
    /// </summary>
    public class CreateProposalPhotoDto
    {
        /// <summary>
        /// Gets or sets the Base64 encoded string of the image to be added to a proposal.
        /// </summary>
        [Base64String(false)]
        public string Image { get; set; } = null!;
    }
}
