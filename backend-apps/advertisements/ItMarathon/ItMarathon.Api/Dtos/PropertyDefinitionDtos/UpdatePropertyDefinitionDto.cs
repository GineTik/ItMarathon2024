using ItMarathon.Api.Dtos.PropertyValueDtos;

namespace ItMarathon.Api.Dtos.PropertyDefinitionDtos
{
    /// <summary>
    /// Represents a Data Transfer Object (DTO) for updating a property definition.
    /// </summary>
    public class UpdatePropertyDefinitionDto : BasePropertyDefinitionDto
    {
        /// <summary>
        /// Gets or sets the collection of property values associated with the property definition.
        /// </summary>
        public ICollection<UpdatePropertyValueDto>? PropertyValues { get; set; }
    }
}
