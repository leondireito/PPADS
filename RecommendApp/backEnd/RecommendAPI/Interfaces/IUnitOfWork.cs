using System.Threading.Tasks;

namespace RecommendAPI.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository {get; }
        IMessageRepository MessageRepository {get;}
        ILikesRepository LikesRepository {get; }
        IMidiaRepository  MidiaRepository {get;}
        Task<bool> Complete();
        bool HasChanges();
    }
}