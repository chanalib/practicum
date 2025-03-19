using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace MagicalMusic.CORE.DTOs
{
    public class ProductDTO
    {
        //public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public double Price { get; set; } = 0;
        public int AdvertiserId { get; set; }
        // public int CustomerId { get; set; }

    }
}
