using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using ItMarathon.Api.Dtos.PropertyValueDtos;

namespace ItMarathon.Api.Dtos.PropertyDtos
{
    /// <summary>
    /// Data transfer object representing a property.
    /// </summary>
    public class PropertyDto
    {
        /// <summary>
        /// Gets or sets the identifier of the property.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the custom value of the property.
        /// </summary>
        public string? CustomValue { get; set; }

        /// <summary>
        /// Gets or sets the property definition associated with this property.
        /// </summary>
        public PropertyDefinitionDto? PropertyDefinition { get; set; }

        /// <summary>
        /// Gets or sets the predefined value associated with this property.
        /// </summary>
        public PropertyValueDto? PredefinedValue { get; set; }
    }
}
