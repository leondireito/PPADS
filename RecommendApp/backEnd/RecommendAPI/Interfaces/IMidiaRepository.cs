using System.Collections.Generic;
using System.Threading.Tasks;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Helpers;

namespace RecommendAPI.Interfaces
{
    public interface IMidiaRepository
    {
        void AddMedia(IMidia midia);

        IEnumerable<IMidia> GetAllMidias();

        Task<PagedList<MidiaDto>> GetMidiassAsync(UserParams userParams);
        IEnumerable<Serie> GetSeries();
        IEnumerable<Filme> GetFilmes();
        IEnumerable<Livro> GetLivros();



        IEnumerable<Post> GetPosts();
    }
}