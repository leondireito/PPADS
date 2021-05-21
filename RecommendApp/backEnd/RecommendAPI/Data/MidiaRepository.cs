using System.Linq;
using System.Threading.Tasks;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Helpers;
using RecommendAPI.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RecommendAPI.Entities.Enums;

namespace RecommendAPI.Data
{
    public class MidiaRepository : IMidiaRepository
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public MidiaRepository(DataContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddMedia(IMidia midia)
        {
            if (midia is Serie)
                context.Series.Add(midia as Serie);
            else if (midia is Filme)
                context.Filmes.Add(midia as Filme);
            else if (midia is Livro)
                context.Livros.Add(midia as Livro);
        }


        public async Task<PagedList<MidiaDto>> GetMidiassAsync(UserParams userParams)
        {
            var query = context.Midias.Include(p => p.User).AsQueryable();

            query = query.Where(x => x.Avaliado == userParams.Avaliado);

            // query = query.Where(u => u.User.UserName != userParams.CurrentUsername);
            if (userParams.MidiaTipo != MidiaTypeEnum.Todos)
                query = query.Where(u => u.Tipo == userParams.MidiaTipo);

            if (!string.IsNullOrEmpty(userParams.MidiaTitulo))
                query = query.Where(u => u.Titulo.Contains(userParams.MidiaTitulo));

            query = userParams.OrderBy switch
            {
                "created" => query.OrderBy(u => u.Criado),
                _ => query.OrderByDescending(u => u.Criado)
            };

            return await PagedList<MidiaDto>.CreateAsync(query.ProjectTo<MidiaDto>(mapper
                .ConfigurationProvider).AsNoTracking(),
                    userParams.PageNumber, userParams.PageSize);
        }

        public async Task<MidiaDto> GetMidiaAsync(int id)
        {
            var midiaDto = new MidiaDto();

            var m = context.Midias.Find(id);

            if (m.Tipo == MidiaTypeEnum.Serie)
            {
                Serie serie = await context.Series
                .Include(x => x.User)
                .Include(x => x.Integrantes)
                .FirstOrDefaultAsync(x => x.Id == id);
                mapper.Map(serie, midiaDto);
            }
            else if (m.Tipo == MidiaTypeEnum.Filme)
            {
                Filme filme = await context.Filmes
                .Include(x => x.User)
                .Include(x => x.Integrantes)
                .FirstOrDefaultAsync(x => x.Id == id);
                mapper.Map(filme, midiaDto);
            }
            else if (m.Tipo == MidiaTypeEnum.Livro)
            {
                Livro livro = await context.Livros
                .Include(x => x.User)
                .Include(x => x.Integrantes)
                .FirstOrDefaultAsync(x => x.Id == id);
                mapper.Map(livro, midiaDto);
            }

            return midiaDto;
        }


    }
}