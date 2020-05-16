using System.Collections.Generic;
using System.Threading.Tasks;
using ChattingApp.API.Helpers;
using ChattingApp.API.Models;

namespace ChattingApp.API.Data
{
    public interface IChattingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<PagedList<User>> GetUsers(UserParams userParams);
        Task<User> GetUser(int id);
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Like> GetLike(int userId, int recepientId);
    }
}