using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicalMusic.CORE.Models;

namespace MagicalMusic.CORE.DTOs
{
    public class UserDTO
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        
        public string role { get; set; }

    }
}
