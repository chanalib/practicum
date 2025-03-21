using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Repositories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAllAsync();
        public Task<User> GetByIdAsync(int id);
        public Task<User> AddAsync(User user);
        public Task<User> UpdateAsync(int id, User user);
        public Task DeleteAsync(int id);
        public User GetUserByCredentials(string userName, string userPassword);

    }
}
