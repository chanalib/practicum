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
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _productRepository;
        public ProductService(IRepositoryManager productrepository)
        {
            _productRepository = productrepository;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await Task.Run(() => _productRepository.Products.GetAll());
        }
        public async Task<Product> GetByIdAsync(int id)
        {
            return await Task.Run(() => _productRepository.Products.GetById(id));
        }
        public async Task AddValueAsync(Product product)
        {
            _productRepository.Products.Add(product);
            await _productRepository.SaveAsync();
        }
        public async Task PutValueAsync(Product product)
        {
            _productRepository.Products.Update(product);
            await _productRepository.SaveAsync();

        }
        public async Task DeleteAsync(Product p)
        {
            _productRepository.Products.Delete(p);
            await _productRepository.SaveAsync();

        }
        public async void UpdatePrice(int id, double price)
        {
            _productRepository.Product.UpdatePrice(id, price);
            await _productRepository.SaveAsync();

        }
    }
}
