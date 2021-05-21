using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using AutoMapper;
using System.Linq;
using RecommendAPI.Extensions;

namespace RecommendAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>()
                .ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
                    src.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
            CreateMap<RegisterDto, AppUser>();
            CreateMap<Message, MessageDto>()
                .ForMember(dest => dest.SenderPhotoUrl, opt => opt.MapFrom(src =>
                    src.Sender.Photos.FirstOrDefault(x => x.IsMain).Url))
                .ForMember(dest => dest.RecipientPhotoUrl, opt => opt.MapFrom(src =>
                    src.Recipient.Photos.FirstOrDefault(x => x.IsMain).Url));
            CreateMap<MessageDto, Message>();
            CreateMap<Midia, MidiaDto>()
             .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.UserName))
             .ForMember(dest => dest.Integrantes, opt => opt.MapFrom(src => src.Integrantes));
            CreateMap<MidiaDto, Midia>()
            .ForMember(dest => dest.Integrantes, opt => opt.MapFrom(src => src.Integrantes));

             CreateMap<Avaliacao, AvaliacaoDto>()
            .ForMember(dest => dest.AvaliadoPorUsername, opt => opt.MapFrom(src => src.AvaliadoPor.UserName))
            .ForMember(dest => dest.AvaliadoPorNome, opt => opt.MapFrom(src => src.AvaliadoPor.Name))
            .ForMember(dest => dest.MidiaAvaliadaId, opt => opt.MapFrom(src => src.MidiaAvaliada.Id))
            .ForMember(dest => dest.MidiaTitulo, opt => opt.MapFrom(src => src.MidiaAvaliada.Titulo));

             CreateMap<AvaliacaoDto, Avaliacao>();
           



        }
    }
}