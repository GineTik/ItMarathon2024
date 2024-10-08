using System.ComponentModel.DataAnnotations;

namespace ItMarathon.Api.Dtos.PropertyDtos
{
    /// <summary>
    /// Data transfer object for property creation.
    /// </summary>
    public class CreatePropertyDto
    {
        /// <summary>
        /// Gets or sets the custom value of the property.
        /// </summary>
        [MaxLength(100)]
        public string? CustomValue { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the property definition associated with this property.
        /// </summary>
        [Range(0, long.MaxValue)]
        public long PropertyDefinitionId { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the predefined value associated with this property.
        /// </summary>
        [Range(0, long.MaxValue)]
        public long? PredefinedValueId { get; set; }
    }
}
