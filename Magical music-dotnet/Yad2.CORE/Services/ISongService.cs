using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface ISongService
    {
        public Task<IEnumerable<Song>> GetAllAsync();
        public Task<Song> GetByIdAsync(int id);
        public Task<Song> AddAsync(SongDTO song);
        public Task<Song> UpdateAsync(int id, SongDTO song);
        public Task DeleteAsync(int id);
    }
}
