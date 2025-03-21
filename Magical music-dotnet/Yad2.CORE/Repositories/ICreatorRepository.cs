using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MagicalMusic.CORE.Models;

namespace MagicalMusic.CORE.Repositories
{
    public interface ICreatorRepository
    {
        public Task<IEnumerable<Creator>> GetAllAsync();
        public Task<Creator> GetByIdAsync(int id);
        public Task<Creator> AddAsync(Creator creator);
        public Task<Creator> UpdateAsync(int id, Creator creator);
        public Task DeleteAsync(int id);

    }
}
