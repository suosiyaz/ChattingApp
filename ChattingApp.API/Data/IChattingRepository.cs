using System.Collections.Generic;
using System.Threading.Tasks;
using ChattingApp.API.Models;

namespace ChattingApp.API.Data
{
    public interface IChattingRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}