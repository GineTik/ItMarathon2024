using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ItMarathon.Api.Dtos.PropertyDtos
{
    /// <summary>
    /// Data transfer object for property update.
    /// </summary>
    public class UpdatePropertyDto : CreatePropertyDto
    {
        /// <summary>
        /// Gets or sets the identifier of the property.
        /// </summary>
        [JsonPropertyOrder(-1)]
        [Range(0, long.MaxValue)]
        public long? Id { get; set; }
    }
}
