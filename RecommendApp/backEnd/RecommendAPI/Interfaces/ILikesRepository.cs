using System.Collections.Generic;
using System.Threading.Tasks;
using RecommendAPI.DTOs;
using RecommendAPI.Entities;
using RecommendAPI.Helpers;

namespace RecommendAPI.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}