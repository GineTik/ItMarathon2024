using AutoMapper;
using ItMarathon.Api.Dtos.PropertyDefinitionDtos;
using ItMarathon.Dal.Entities;


namespace ItMarathon.Api.Dtos.Profiles
{
    /// <summary>
    /// Profile configuration for mapping between <see cref="PropertyDefinition"/> and its related DTOs.
    /// </summary>
    public class PropertyDefinitionProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyDefinitionProfile"/> class.
        /// </summary>
        public PropertyDefinitionProfile()
        {
            CreateMap<PropertyDefinition, PropertyDefinitionDto>()
                .ForMember(dest => dest.PropertyValues, opt => opt.MapFrom(src => src.PropertyValues))
                .ReverseMap();

            CreateMap<CreatePropertyDefinitionDto, PropertyDefinition>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow));

            CreateMap<UpdatePropertyDefinitionDto, PropertyDefinition>()
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
