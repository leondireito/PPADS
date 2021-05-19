using System.Threading.Tasks;
using RecommendAPI.Entities;

namespace RecommendAPI.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}