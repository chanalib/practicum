using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using MagicalMusic.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.SERVICE
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;
        private readonly IMapper _mapper;

        public SongService(ISongRepository songRepository, IMapper mapper)
        {
            _songRepository = songRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Song>> GetAllAsync() => await _songRepository.GetAllAsync();
        public async Task<Song> GetByIdAsync(int id) => await _songRepository.GetByIdAsync(id);
        public async Task<Song> AddAsync(SongDTO song)
        {
            var songMap = _mapper.Map<Song>(song);

            return await _songRepository.AddAsync(songMap);
        }
        public async Task<Song> UpdateAsync(int id, SongDTO song)
        {
            var songMap = _mapper.Map<Song>(song);
            return await _songRepository.UpdateAsync(id, songMap);
        }
        public async Task DeleteAsync(int id) => await _songRepository.DeleteAsync(id);
    }
}
