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
    public class CustomerService : ICustomerService
    {
        private readonly IRepositoryManager _customerRepository;
        public CustomerService(IRepositoryManager customerepository)
        {
            _customerRepository = customerepository;
        }
        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await Task.Run(() => _customerRepository.Customers.GetAll());
        }
        public async Task<Customer> GetByIdAsync(int id)
        {
            return await Task.Run(() => _customerRepository.Customers.GetById(id));
        }
        public async Task AddValueAsync(Customer customer)
        {
            _customerRepository.Customers.Add(customer);
            await _customerRepository.SaveAsync();
        }
        public async Task PutValueAsync(Customer customer)
        {
            _customerRepository.Customers.Update(customer);
            await _customerRepository.SaveAsync();
        }
        public async Task DeleteAsync(Customer a)
        {
            _customerRepository.Customers.Delete(a);
            await _customerRepository.SaveAsync();
        }
        public async Task UpdateStatusAsync(int id, bool status)
        {
            _customerRepository.Customer.Status(id, status);
            await _customerRepository.SaveAsync();
        }
    }
}
