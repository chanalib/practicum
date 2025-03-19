using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Services;
using Microsoft.AspNetCore.Mvc;
using Yad2.SERVICE;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicalMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>

        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerservice, IMapper mapper)
        {
            _mapper = mapper;
            _customerService = customerservice;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var list = await _customerService.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(listDto);
        }

        //GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var customer = await _customerService.GetByIdAsync(id);
            var dto = _mapper.Map<CustomerDTO>(customer);
            return Ok(dto);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task PostAsync([FromBody] CustomerPost value)
        {
            var dto = _mapper.Map<Customer>(value);
            await _customerService.AddValueAsync(dto);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{customer}")]
        public async void Put(/*int id,*/ [FromBody] CustomerUpdate value)
        {
            var dto = _mapper.Map<Customer>(value);
            await _customerService.PutValueAsync(dto);
        }

        //// DELETE api/<CustomerController>/5
        [HttpDelete("{customer}")]
        public async void DeleteAsync(CustomerUpdate c)
        {
            var dto = _mapper.Map<Customer>(c);
            await _customerService.DeleteAsync(dto);
        }
        [HttpPut("{id}/Status")]
        public void UpdateStatus(int id, bool status)
        {
            _customerService.UpdateStatusAsync(id, status);
        }
    }
}
