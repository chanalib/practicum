using Yad2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Yad2.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static IDataContext _context;

        public ProductsController(IDataContext context)
        {
            _context = context;
        }
        // GET: api/<productsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _context.Products;
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           
            foreach (var product in _context.Products)
            {
                if (product.Id == id)
                    return Ok(product);
            }
            return NotFound();
        }

        // POST api/<productsController>
        [HttpPost]
        public void Post([FromBody] Product value)
        {
            _context.Products.Add(value);

        }

        // PUT api/<productsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product value)
        {
            for (int i = 0; i < _context.Products.Count; i++)
            {
                if (_context.Products[i].Id == id)
                {
                    _context.Products[i] = value;
                }
            }
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (var product in _context.Products)
            {
                if (product.Id == id)
                { _context.Products.Remove(product); return; }
            }
        }
        [HttpPut("{id}/price")]
        public void Status(int id, int price)
        {
            foreach (var product in _context.Products)
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
