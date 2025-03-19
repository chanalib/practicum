using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.Services
{
    public interface IRepositoryService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddValueAsync(T entity);
        Task PutValueAsync(T entity);
        Task DeleteAsync(T a);
    }
}
