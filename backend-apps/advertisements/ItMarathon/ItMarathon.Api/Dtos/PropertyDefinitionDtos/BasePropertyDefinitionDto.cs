using ItMarathon.Dal.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ItMarathon.Api.Dtos.PropertyDefinitionDtos
{
    /// <summary>
    /// Base data transfer object for other property definition dtos.
    /// </summary>
    public class BasePropertyDefinitionDto
    {
        /// <summary>
        /// Gets or sets the name of the property definition.
        /// </summary>
        /// <example>Property Name</example>
        [JsonPropertyOrder(-3)]
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Gets or sets the type of the property definition.
        /// </summary>
        /// <example>Predefined</example>
        /// <example>Custom</example>
        [Required(ErrorMessage = "PropertyDefinitionType is required.")]
        [JsonPropertyOrder(-2)]
        [EnumDataType(typeof(PropertyDefinitionType))]
        public PropertyDefinitionType PropertyDefinitionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the property is mandatory.
        /// </summary>
        /// <example>true</example>
        [Required(ErrorMessage = "IsMandatory is required.")]
        [JsonPropertyOrder(-1)]
        public bool IsMandatory { get; set; }

        /// <summary>
        /// Gets or sets the category for the property definition.
        /// </summary>
        [JsonPropertyOrder(-1)]
        public string? Category { get; set; }
    }
}
