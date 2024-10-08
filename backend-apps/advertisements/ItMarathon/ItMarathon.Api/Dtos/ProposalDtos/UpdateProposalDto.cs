using ItMarathon.Api.Dtos.PhotoDtos;
using ItMarathon.Api.Dtos.PropertyDtos;

namespace ItMarathon.Api.Dtos.ProposalDtos
{
    /// <summary>
    /// Data transfer object for proposal update.
    /// </summary>
    public class UpdateProposalDto : BaseProposalDto
    {
        /// <summary>
        /// Gets or sets the collection of photos associated with the proposal.
        /// </summary>
        public ICollection<ProposalPhotoDto>? Photos { get; set; } = Array.Empty<ProposalPhotoDto>();

        /// <summary>
        /// Gets or sets the collection of properties associated with the proposal.
        /// </summary>
        public ICollection<UpdatePropertyDto>? Properties { get; set; } = Array.Empty<UpdatePropertyDto>();
    }
}
