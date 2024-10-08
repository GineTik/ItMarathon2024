using AutoMapper;
using ItMarathon.Api.Dtos.PhotoDtos;
using ItMarathon.Api.Dtos.PropertyDtos;
using ItMarathon.Api.Dtos.ProposalDtos;
using ItMarathon.Dal.Entities;

namespace ItMarathon.Api.Dtos.Handler
{
    /// <summary>
    /// Profile configuration for mapping between <see cref="Proposal"/> and its related DTOs.
    /// </summary>
    public class ProposalProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProposalProfile"/> class.
        /// </summary>
        public ProposalProfile()
        {
            CreateMap<Proposal, ProposalDto>()
                .ReverseMap();
            CreateMap<ProposalDto, CreateProposalDto>()
                .ForMember(dest => dest.Properties, opt => opt.MapFrom(src => src.Properties!.Select(p => new CreatePropertyDto
                {
                    CustomValue = p.CustomValue,
                    PredefinedValueId = p.PredefinedValue != null ? p.PredefinedValue.Id : null,
                    PropertyDefinitionId = p.PropertyDefinition!.Id

                }).ToList()))
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos!.Select(p => new CreateProposalPhotoDto
                {
                    Image = p.Image!
                }).ToList()));

            CreateMap<ProposalDto, UpdateProposalDto>()
                .ForMember(dest => dest.Properties, opt => opt.MapFrom(src => src.Properties!.Select(p => new UpdatePropertyDto
                {
                    Id = p.Id,
                    CustomValue = p.CustomValue,
                    PredefinedValueId = p.PredefinedValue != null ? p.PredefinedValue.Id : null,
                    PropertyDefinitionId = p.PropertyDefinition!.Id
                }).ToList()))
                .ForMember(dest => dest.Photos, opt => opt.MapFrom(src => src.Photos!.Select(p => new ProposalPhotoDto
                {
                    Id = p.Id,
                    Image = p.Image,
                    Url = p.Url
                }).ToList()));

            CreateMap<CreateProposalDto, Proposal>()
                .ForMember(dest => dest.CreatedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Photos, opt => opt.Ignore());

            CreateMap<UpdateProposalDto, Proposal>()
                .ForMember(dest => dest.LastModifiedOn, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.Properties, opt => opt.Ignore())
                .ForMember(dest => dest.Photos, opt => opt.Ignore());

            CreateMap<ProposalPhoto, ProposalPhotoDto>()
                .ReverseMap();
            CreateMap<CreateProposalPhotoDto, ProposalPhoto>();
        }
    }
}
