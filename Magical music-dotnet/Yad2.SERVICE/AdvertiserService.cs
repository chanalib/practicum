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
    public class AdvertiserService : IAdvertiserService
    {
        private readonly IRepositoryManager _advertiserRepository;
        public AdvertiserService(IRepositoryManager advertiserRepository)
        {
            _advertiserRepository = advertiserRepository;
        }
        public async Task<IEnumerable<Advertiser>> GetAllAsync()
        {
            return await Task.Run(() => _advertiserRepository.Advertisers.GetAll());
        }
        public async Task<Advertiser> GetByIdAsync(int id)
        {
            return await Task.Run(() => _advertiserRepository.Advertisers.GetById(id));
        }
        public async Task AddValueAsync(Advertiser advertiser)
        {
            _advertiserRepository.Advertisers.Add(advertiser);
            await _advertiserRepository.SaveAsync();
        }
        public async Task PutValueAsync(Advertiser advertiser)
        {
            _advertiserRepository.Advertisers.Update(advertiser);
            await _advertiserRepository.SaveAsync();
        }
        public async Task DeleteAsync(Advertiser a)
        {
            _advertiserRepository.Advertisers.Delete(a);
            await _advertiserRepository.SaveAsync();
        }
        public async Task Status(int id, string status)
        {
            _advertiserRepository.Advertiser.StatusVal(id, status);
            await _advertiserRepository.SaveAsync();
        }
    }
}
