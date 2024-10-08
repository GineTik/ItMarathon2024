using ItMarathon.Api.Dtos.PropertyValueDtos;
using System.Text.Json.Serialization;

namespace ItMarathon.Api.Dtos.PropertyDefinitionDtos
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a property definition.
    /// </summary>
    public class PropertyDefinitionDto : BasePropertyDefinitionDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the property definition.
        /// </summary>
        /// <example>14</example>
        [JsonPropertyOrder(-4)]
        public long Id { get; set; }


        /// <summary>
        /// Gets or sets the collection of property values associated with the property definition.
        /// </summary>
        public ICollection<PropertyValueDto>? PropertyValues { get; set; }
    }
}
