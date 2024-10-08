using AutoMapper;
using ItMarathon.Api.Dtos.PropertyDtos;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Dtos.Profiles
{
    /// <summary>
    /// Profile configuration for mapping between <see cref="Property"/> and <see cref="PropertyDto"/> 
    /// and <see cref="CreatePropertyDto"/>.
    /// </summary>
    public class PropertyProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyProfile"/> class.
        /// </summary>
        public PropertyProfile()
        {
            CreateMap<Property, PropertyDto>()
                .ReverseMap();
            CreateMap<CreatePropertyDto, Property>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
            CreateMap<UpdatePropertyDto, Property>()
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}
