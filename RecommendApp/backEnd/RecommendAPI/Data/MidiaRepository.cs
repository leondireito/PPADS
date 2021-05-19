using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Helpers;
using RecommendAPI.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using RecommendAPI.Data;

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

        public IEnumerable<IMidia> GetAllMidias()
        {
            var midias = new List<IMidia>();

            midias.AddRange(GetSeries());
            midias.AddRange(GetFilmes());
            midias.AddRange(GetLivros());

            return midias;

        }

         public async Task<PagedList<MidiaDto>> GetMidiassAsync(UserParams userParams)
        {
            var query = context.Midias.Include(p => p.User).AsQueryable();

           // query = query.Where(u => u.User.UserName != userParams.CurrentUsername);
          
            query = userParams.OrderBy switch
            {
                "created" => query.OrderBy(u => u.Criado),
                _ => query.OrderByDescending(u => u.Criado)
            };
            
            return await PagedList<MidiaDto>.CreateAsync(query.ProjectTo<MidiaDto>(mapper
                .ConfigurationProvider).AsNoTracking(), 
                    userParams.PageNumber, userParams.PageSize);
        }


        public IEnumerable<Serie> GetSeries()
        {
            return context.Series.Include(p => p.Elencos).ToList();
        }

        public IEnumerable<Filme> GetFilmes()
        {
            return context.Filmes.Include(p => p.Elencos).ToList();
        }

        public IEnumerable<Livro> GetLivros()
        {
            return context.Livros.Include(p => p.Autores).ToList();
        }

        public IEnumerable<Post> GetPosts()
        {
            return context.Posts.Include(p => p.Tags).ToList();
        }
    }
}