using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.DATA.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IRepository<Album> Products { get; }
        public IRepository<Customer> Customers { get; }
        public IRepository<Advertiser> Advertisers { get; }
        public IAlbumrRepository Customer { get; }
        public ISongRepository Product { get; }
        public IUserRepository Advertiser { get; }
        public RepositoryManager(DataContext context, IRepository<Album>
            productRepository, IRepository<Customer> customerRepository,
            IRepository<Advertiser> advertiserRepository,
            IUserRepository advertiser, ISongRepository product, IAlbumrRepository customer)
        {
            _context = context;
            Products = productRepository;
            Customers = customerRepository;
            Advertisers = advertiserRepository;
            Customer = customer;
            Product = product;
            Advertiser = advertiser;
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
