using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface ICustomerService : IRepositoryService<Customer>
    {

        Task UpdateStatusAsync(int id, bool status);


    }
}
