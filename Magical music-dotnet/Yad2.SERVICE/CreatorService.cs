using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using MagicalMusic.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.SERVICE
{
    public class CreatorService : ICreatorService
    {
        private readonly ICreatorRepository _creatorRepository;
        private readonly IMapper _mapper;

        public CreatorService(ICreatorRepository creatorRepository, IMapper mapper)
        {
            _creatorRepository = creatorRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Creator>> GetAllAsync() => await _creatorRepository.GetAllAsync();
        public async Task<Creator> GetByIdAsync(int id) => await _creatorRepository.GetByIdAsync(id);
        public async Task<Creator> AddAsync(CreatorDTO creatorDTO)
        {
            var creator = new Creator
            {
                Name = creatorDTO.Name,

            };
            return await _creatorRepository.AddAsync(creator);
        }
       


       
        public async Task<Creator> UpdateAsync(int id, CreatorDTO Creator)
        {
            var creatorMap = _mapper.Map<Creator>(Creator);

            return await _creatorRepository.UpdateAsync(id, creatorMap);
        }
        public async Task DeleteAsync(int id) => await _creatorRepository.DeleteAsync(id);

    }
}
