using System.ComponentModel.DataAnnotations;

namespace ItMarathon.Api.Dtos.PropertyValueDtos
{
    /// <summary>
    /// Represents a Data Transfer Object (DTO) for creating a property value.
    /// </summary>
    public class CreatePropertyValueDto
    {
        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        /// <example>Example Value</example>
        [Required(ErrorMessage = "Value is required.")]
        [StringLength(100, ErrorMessage = "Value cannot exceed 100 characters.")]
        public string Value { get; set; } = null!;

        /// <summary>
        /// Gets or sets the optional identifier of the parent property value.
        /// </summary>
        public long? ParentPropertyValueId { get; set; }
    }
}
