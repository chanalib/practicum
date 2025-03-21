using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.DATA.Repositories
{
    public class creatorRepository : ICreatorRepository
    {
        private readonly DataContext _context;
        public creatorRepository(DataContext context) { _context = context; }

        public async Task<IEnumerable<Creator>> GetAllAsync() => await _context.Creators.Include(s => s.Songs).ToListAsync();

        public async Task<Creator> GetByIdAsync(int id) => await _context.Creators.FindAsync(id);

        public async Task<Creator> GetByNameAsync(string name) => await _context.Creators.FirstOrDefaultAsync(s => s.Name == name);
        public async Task<Creator> AddAsync(Creator entity)
        {

            await _context.Creators.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Creator> UpdateAsync(int id, Creator entity)
        {
            Creator s = await _context.Creators.SingleOrDefaultAsync(act => act.Id == id);
            if (s == null) return null;
            else
            {

                s.Name = entity.Name;
                s.Songs = entity.Songs;

            }
            await _context.SaveChangesAsync();
            return s;
        }


        public async Task DeleteAsync(int id) { var entity = await _context.Creators.FindAsync(id); if (entity != null) { _context.Creators.Remove(entity); await _context.SaveChangesAsync(); } }
    }
}
