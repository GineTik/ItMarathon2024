using ItMarathon.Api.Dtos.PropertyValueDtos;

namespace ItMarathon.Api.Dtos.PropertyDefinitionDtos
{
    /// <summary>
    /// Represents a Data Transfer Object (DTO) for creating a property definition.
    /// </summary>
    public class CreatePropertyDefinitionDto : BasePropertyDefinitionDto
    {
        /// <summary>
        /// Gets or sets the collection of property values associated with the property definition.
        /// </summary>
        public ICollection<CreatePropertyValueDto>? PropertyValues { get; set; }
    }
}
