using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.Repositories
{
    public interface IAdvertiserRepository
    {
        //List<Advertiser> GetList();
        //Advertiser SearchId(int id);
        //void AddVal(Advertiser val);
        //void PutVal(int id,Advertiser val);
        //void DeleteVal(int id);
        void StatusVal(int id, string status);

    }
}
