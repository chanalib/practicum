using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.Repositories
{
    public interface ICustomerRepository
    {
        //List<Customer> GetList();
        //Customer GetId(int id);
        //void AddVal(Customer customer);
        //void UpdateVal(int id,Customer customer);
        //void DeleteVal(int id);
        public void Status(int id, bool status);

    }
}
