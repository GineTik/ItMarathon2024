using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ItMarathon.Api.Dtos.PropertyValueDtos
{
    /// <summary>
    /// Represents a Data Transfer Object (DTO) for updating a property value.
    /// </summary>
    public class UpdatePropertyValueDto : CreatePropertyValueDto
    {
        /// <summary>
        /// Gets or sets the unique identifier of the property value.
        /// </summary>
        [JsonPropertyOrder(-1)]
        [Range(0, long.MaxValue)]
        public long? Id { get; set; }
    }
}
