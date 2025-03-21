using MagicalMusic.CORE.Models; 
using MagicalMusic.CORE.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.DATA.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.Include(u => u.Songs).ToListAsync();

        public async Task<User> GetByIdAsync(int id) => await _context.Users.FindAsync(id);

        public async Task<User> GetByEmailAsync(string email) => await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<User> AddAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<User> UpdateAsync(int id, User entity)
        {
            User u = await _context.Users.SingleOrDefaultAsync(act => act.Id == id);
            if (u == null) return null;
            else
            {

                u.Name = entity.Name;
                u.Password = entity.Password;
                u.Email = entity.Email;
                u.Role = entity.Role;
                u.Songs = entity.Songs;

            }
            await _context.SaveChangesAsync();
            return u;

        }


        public async Task DeleteAsync(int id) { var entity = await _context.Users.FindAsync(id); if (entity != null) { _context.Users.Remove(entity); await _context.SaveChangesAsync(); } }


        public User GetUserByCredentials(string userName, string userPassword)
        {
            return _context.Users.FirstOrDefault(user => user.Name == userName && user.Password == userPassword);
        }
    }
}
