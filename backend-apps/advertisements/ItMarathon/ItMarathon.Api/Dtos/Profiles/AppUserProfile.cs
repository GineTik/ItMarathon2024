using AutoMapper;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Dtos.Profiles
{
    /// <summary>
    /// Profile configuration for mapping between <see cref="AppUser"/> and <see cref="AppUserDto"/>.
    /// </summary>
    public class AppUserProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppUserProfile"/> class.
        /// </summary>
        public AppUserProfile()
        {
            CreateMap<AppUser, AppUserDto>()
                .ReverseMap();
        }
    }
}
