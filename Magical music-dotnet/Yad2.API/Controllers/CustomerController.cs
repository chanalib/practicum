using System.Web.Mvc;
using Yad2.CORE.Models;
using Yad2.SERVICE;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerservice)
        {
            _customerService = customerservice;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return CustomerService.GetAll();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            foreach (Customer customer in _context.Customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return new Customer();
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            _context.Customers.Add(value);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Customer value)
        {
            for (int i = 0; i < _context.Customers.Count; i++)
            {
                if (_context.Customers[i].Id == id)
                {
                    _context.Customers[i] = value;
                    return;
                }
            }
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Customer customer in _context.Customers)
            {
                if (customer.Id == id)
                {
                    _context.Customers.Remove(customer);
                    return;
                }
            }
        }
        [HttpPut("{id}/status")]
        public void Kind(int id, bool status)
        {
            foreach (var customer in _context.Customers)
            {
                if (customer.Id == id)
                {
                    customer.IsActive = status;
                }
            }
        }
    }
}
