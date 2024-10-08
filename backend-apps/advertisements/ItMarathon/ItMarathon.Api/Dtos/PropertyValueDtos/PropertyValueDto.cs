namespace ItMarathon.Api.Dtos.PropertyValueDtos
{
    /// <summary>
    /// Represents a data transfer object (DTO) for a property value.
    /// </summary>
    public class PropertyValueDto
    {
        /// <summary>
        /// Gets or sets the unique identifier for the property value.
        /// </summary>
        /// <example>1</example>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        public string Value { get; set; } = null!;

        /// <summary>
        /// Gets or sets the parent property value associated with this property value.
        /// This field is optional and can be null.
        /// </summary>
        public PropertyValueDto? ParentPropertyValue { get; set; }
    }
}
