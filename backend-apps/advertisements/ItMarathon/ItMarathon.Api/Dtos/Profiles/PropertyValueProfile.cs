using AutoMapper;
using ItMarathon.Api.Dtos.PropertyValueDtos;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Dtos.Profiles
{
    /// <summary>
    /// Profile configuration for mapping between <see cref="PropertyValue"/> and its related DTOs.
    /// </summary>
    public class PropertyValueProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValueProfile"/> class.
        /// </summary>
        public PropertyValueProfile()
        {
            CreateMap<PropertyValue, PropertyValueDto>()
                .ReverseMap();

            CreateMap<CreatePropertyValueDto, PropertyValue>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.ParentId, opt => opt.MapFrom(src => src.ParentPropertyValueId));

            CreateMap<UpdatePropertyValueDto, PropertyValue>()
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}
