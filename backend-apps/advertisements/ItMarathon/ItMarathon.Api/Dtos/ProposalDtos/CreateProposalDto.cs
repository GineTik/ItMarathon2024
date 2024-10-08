using ItMarathon.Api.Dtos.PhotoDtos;
using ItMarathon.Api.Dtos.PropertyDtos;

namespace ItMarathon.Api.Dtos.ProposalDtos
{
    /// <summary>
    /// Data transfer object for proposal creation.
    /// </summary>
    public class CreateProposalDto : BaseProposalDto
    {
        /// <summary>
        /// Gets or sets the collection of photos associated with the proposal.
        /// </summary>
        public ICollection<CreateProposalPhotoDto>? Photos { get; set; } = Array.Empty<CreateProposalPhotoDto>();

        /// <summary>
        /// Gets or sets the collection of properties associated with the proposal.
        /// </summary>
        public ICollection<CreatePropertyDto>? Properties { get; set; } = Array.Empty<CreatePropertyDto>();
    }
}
