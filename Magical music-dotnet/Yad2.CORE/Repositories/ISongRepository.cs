using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.Repositories
{
    public interface ISongRepository
    {
        //List<Product> GetList();
        //Product SearchId(int id);
        //void AddPro(Product product);
        //void PutVal(int id, Product product);
        //void DeleteVal(int id);
        void UpdatePrice(int id, double price);

    }
}
