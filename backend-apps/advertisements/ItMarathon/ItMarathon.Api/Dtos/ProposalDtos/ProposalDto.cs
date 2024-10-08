using ItMarathon.Api.Dtos.PhotoDtos;
using ItMarathon.Api.Dtos.PropertyDtos;
using System.Text.Json.Serialization;

namespace ItMarathon.Api.Dtos.ProposalDtos
{
    /// <summary>
    /// Data transfer object for proposal information.
    /// </summary>
    public class ProposalDto : BaseProposalDto
    {
        /// <summary>
        /// Gets or sets the identifier for the proposal.
        /// </summary>
        [JsonPropertyOrder(-3)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the date and time the proposal was created.
        /// </summary>
        [JsonPropertyOrder(-2)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the date and time the proposal was last modified.
        /// </summary>
        [JsonPropertyOrder(-1)]
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// Gets or sets the collection of photos associated with the proposal.
        /// </summary>
        [JsonPropertyOrder(1)]
        public ICollection<ProposalPhotoDto>? Photos { get; set; }

        /// <summary>
        /// Gets or sets the collection of properties associated with the proposal.
        /// </summary>
        [JsonPropertyOrder(2)]
        public ICollection<PropertyDto>? Properties { get; set; }

        /// <summary>
        /// Gets or sets the user associated with the proposal.
        /// </summary>
        [JsonPropertyOrder(3)]
        public AppUserDto? AppUser { get; set; }
    }
}
