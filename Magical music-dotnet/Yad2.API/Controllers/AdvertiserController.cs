using Microsoft.AspNetCore.Mvc;
using Yad2.data;
using Yad2.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yad2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        
        private readonly IDataContext _advertiser;
        // GET: api/<advertisersController>
        public AdvertiserController(IDataContext context)
        {
            _advertiser = context;
        }
        [HttpGet]
        public IEnumerable<Advertiser> Get()
        {
            return _advertiser.Advertisers;
        }

        // GET api/<AdvertisersController>/5
        [HttpGet("{id}")]
        public Advertiser Get(int id)
        {
            foreach (var secretery in _advertiser.Advertisers)
            {
                if(secretery.Id == id) 
                    return secretery;
            }
            return new Advertiser();
        }

        // POST api/<AdvertisersController>
        [HttpPost]
        public void Post([FromBody] Advertiser value)
        {
            _advertiser.Advertisers.Add(value);
        }

        // PUT api/<AdvertisersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Advertiser value)
        {
            for(int i=0;i<_advertiser.Advertisers.Count; i++)
            {
                if (_advertiser.Advertisers[i].Id == id)
                {
                    _advertiser.Advertisers[i] = value;
                    return;
                }
            }
        }

        // DELETE api/<AdvertisersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach(var item in _advertiser.Advertisers)
            {
                if(item.Id==id)
                {
                    _advertiser.Advertisers.Remove(item);
                    return;
                }    
            }
        }
        [HttpPut("{id}/price")]
        public void Price(int id,double price)
        {
            foreach(var  item in _advertiser.Advertisers)   
            {
                if (item.Id == id)
                    item.Price = price;
            }
        }
    }
}
