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
            CreateMap<SerieDto, Serie>();

            CreateMap<Serie, SerieDto>();
            //.ForMember(dest => dest.ElencosDto, opt => opt.MapFrom (src => new Elenco { Nome = src.Elencos.}));
            CreateMap<FilmeDto, Filme>();
            CreateMap<Filme, FilmeDto>();
            CreateMap<LivroDto, Livro>()
                .ForMember(dest => dest.Editora, opt => opt.MapFrom(src => new Editora { Nome = src.Editora }));
            CreateMap<Livro, LivroDto>()
                .ForMember(dest => dest.Editora, opt => opt.MapFrom(src => src.Editora.Nome));

            CreateMap<Midia, MidiaDto>()
             .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User.UserName));



        }
    }
}