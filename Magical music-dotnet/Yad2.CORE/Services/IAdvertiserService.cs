using MagicalMusic.CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.CORE.Services
{
    public interface IAdvertiserService : IRepositoryService<Advertiser>
    {

        Task Status(int id, string status);

    }
}
