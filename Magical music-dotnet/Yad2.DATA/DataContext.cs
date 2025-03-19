using MagicalMusic.CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicalMusic.DATA
{
    public class DataContext : DbContext
    {
        public DbSet<Advertiser> Advertisers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Album> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=My_db");
            optionsBuilder.LogTo(messege => Debug.WriteLine(messege));
        }

        //public DataContext(
        //{
        //    Advertisers = new List<Advertiser> { new Advertiser { Id = 1, Id_product = 1, Kind_Advertiser = "old", Name = "Chaim",Status="ective" } };
        //    Customers = new List<Customer> { new Customer { Id = 1, Name = "Nomi", IsActive = true, Mail = "1@gmail.com" } };
        //    Products = new List<Product> { new Product { Id = 1, Description = "small cupboard", Price = 150, Status = "by using 5 years" } };
        //}
    }
}
