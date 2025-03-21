using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface ICreatorService
    {

        public Task<IEnumerable<Creator>> GetAllAsync();
        public Task<Creator> GetByIdAsync(int id);
        public Task<Creator> AddAsync(CreatorDTO creator);
        public Task<Creator> UpdateAsync(int id, CreatorDTO creator);
        public Task DeleteAsync(int id);

    }
}
