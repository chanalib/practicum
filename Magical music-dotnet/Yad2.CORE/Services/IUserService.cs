using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAllAsync();
        public Task<User> GetByIdAsync(int id);
        public Task<User> AddAsync(UserDTO user);
        public Task<User> UpdateAsync(int id, UserDTO user);
        public Task DeleteAsync(int id);
        public User Authenticate(string userName, string userPassword);
    }
}
