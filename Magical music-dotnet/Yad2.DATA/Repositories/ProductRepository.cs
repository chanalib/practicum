using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MagicalMusic.DATA.Repositories
{
    public class ProductRepository : Repository<Album>, ISongRepository
    {

        public ProductRepository(DataContext context) : base(context)
        {
        }
        #region no  
        //private readonly DataContext _context;


        //public List<Product> GetList()
        //{
        //    return _context.Products.ToList();
        //}
        //public Product SearchId(int id) 
        //{
        //    foreach (var product in _context.Products)
        //    {
        //        if (product.Id == id)
        //            return product;
        //    }
        //    return new Product();
        //}
        //public void AddPro(Product product)
        //{
        //    _context.Products.Add(product);
        //}
        //public void PutVal(int id, Product product)
        //{
        //    Product item=_context.Products.ToList().Find(x => x.Id == id);
        //    item = product;
        //}
        //public void DeleteVal(int id)
        //{
        //    foreach (var product in _context.Products)
        //    {
        //        if (product.Id == id)
        //        { _context.Products.Remove(product); return; }
        //    }
        //}
        #endregion

        public void UpdatePrice(int id, double price)
        {
            foreach (var product in _dbSet)
            {
                if (product.Id == id)
                {
                    product.Price = price;
                    return;
                }
            }
        }
    }
}
