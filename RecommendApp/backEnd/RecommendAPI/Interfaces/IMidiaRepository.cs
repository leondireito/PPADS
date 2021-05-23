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
        Task<PagedList<MidiaDto>> GetMidiassAsync(UserParams userParams);
        Task<MidiaDto> GetMidiaAsync(int id);
        void AprovaMidia(int id);
         Task<IList<MidiaDto>> VeridicaMidiaDuplicada(string titulo);

    }
}