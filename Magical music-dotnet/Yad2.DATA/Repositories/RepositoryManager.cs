using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.DATA.Repositories
{
    //public class RepositoryManager : IRepositoryManager
    //{
    //    private readonly DataContext _context;
    //    public IRepository<Creator> Products { get; }
    //    public IRepository<Customer> Customers { get; }
    //    public IRepository<User> Users { get; }
    //    public IAlbumrRepository Customer { get; }
    //    public ISongRepository Product { get; }
    //    public IUserRepository User { get; }
    //    public RepositoryManager(DataContext context, IRepository<Creator>
    //        productRepository, IRepository<Customer> customerRepository,
    //        IRepository<User> userRepository,
    //        IUserRepository User, ISongRepository product, IAlbumrRepository customer)
    //    {
    //        _context = context;
    //        Products = productRepository;
    //        Customers = customerRepository;
    //        Users = userRepository;
    //        Customer = customer;
    //        Product = product;
    //        User = User;
    //    }
    //    public async Task SaveAsync()
    //    {
    //        await _context.SaveChangesAsync();
    //    }
    //}
}
