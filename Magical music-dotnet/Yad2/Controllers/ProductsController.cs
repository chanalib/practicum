using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using AutoMapper;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicalMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static IProductService _productService;
        private readonly IMapper _mapper;
        public ProductsController(IProductService context, IMapper mapper)
        {
            _productService = context;
            _mapper = mapper;
        }
        // GET: api/<productsController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _productService.GetAllAsync();
            var listdto = _mapper.Map<IEnumerable<ProductDTO>>(list);
            return Ok(listdto);
        }

        // GET api/<productsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetByIdAsync(int id)
        {
            var pro = await _productService.GetByIdAsync(id);
            var dto = _mapper.Map<ProductDTO>(pro);
            return Ok(dto);
        }

        // POST api/<productsController>
        [HttpPost]
        public async Task Post([FromBody] ProductDTO value)
        {
            var dto = _mapper.Map<Album>(value);
            await _productService.AddValueAsync(dto);

        }

        // PUT api/<productsController>/5
        [HttpPut("{products}")]
        public async Task Put(/*int id,*/ [FromBody] ProductUpdate value)
        {
            var dto = _mapper.Map<Album>(value);
            await _productService.PutValueAsync(/*id,*/ dto);
        }

        // DELETE api/<productsController>/5
        [HttpDelete("{product}")]
        public async Task Delete(ProductUpdate p)
        {
            var dto = _mapper.Map<Album>(p);
            await _productService.DeleteAsync(dto);
        }
        [HttpPut("{id}/price")]
        public void UpdatePrice(int id, int price)
        {
            _productService.UpdatePrice(id, price);
        }
    }
}
