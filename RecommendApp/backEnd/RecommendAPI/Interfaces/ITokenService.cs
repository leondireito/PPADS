using RecommendAPI.Entities;

namespace RecommendAPI.Interfaces
{
    public interface ITokenService
    {
         string CreateToken(AppUser  user);
    }
}