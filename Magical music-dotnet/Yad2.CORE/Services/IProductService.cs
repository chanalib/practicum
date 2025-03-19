using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface IProductService : IRepositoryService<Product>
    {

        void UpdatePrice(int id, double price);

    }
}
