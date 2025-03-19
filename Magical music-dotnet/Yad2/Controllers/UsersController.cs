using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Services;
using Microsoft.AspNetCore.Mvc;



namespace MagicalMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IAdvertiserService _usersService;
        private readonly IMapper _mapper;
        // GET: api/<advertisersController>
        public UsersController(IAdvertiserService context, IMapper mapper)
        {
            _usersService = context;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _usersService.GetAllAsync();
            var listDto = _mapper.Map<IEnumerable<AdvertisterDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<AdvertisersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var user = await _usersService.GetByIdAsync(id);
            var advertisterDto = _mapper.Map<AdvertisterDTO>(user);
            return Ok(advertisterDto);
        }

        // POST api/<AdvertisersController>
        [HttpPost]
        public async Task Post([FromBody] userPost value)
        {
            var dto = _mapper.Map<Advertiser>(value);
            await _usersService.AddValueAsync(dto);
        }

        // PUT api/<AdvertisersController>/5
        [HttpPut(/*"{id}"*/)]
        public async void Put([FromBody] userUpdate value)
        {
            var dto = _mapper.Map<Advertiser>(value);
            await _usersService.PutValueAsync(dto);
        }

        // DELETE api/<AdvertisersController>/5
        [HttpDelete("{advertisers}")]
        public async Task Delete(userUpdate advertiser)
        {
            var dto = _mapper.Map<Advertiser>(advertiser);
            await _usersService.DeleteAsync(dto);
        }
        [HttpPut("{id}/status")]
        public async Task Status(int id, string status)
        {
            await _usersService.Status(id, status);
        }
    }
}
