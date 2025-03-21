using Microsoft.AspNetCore.Mvc;
using Music.Core.Models;
using Music.Core.Services;
using Music.Service;
using Music.Core.Dtos;
using System.Diagnostics;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SingerController : ControllerBase
    {
        private readonly ISingerService _singerService;
        public SingerController(ISingerService singerService)
        {
            _singerService = singerService;
        }


        [HttpGet]
        public async Task<IEnumerable<Singer>> GetAll()
        {
            return await _singerService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Singer>> GetById(int id)
        {
            var singer = await _singerService.GetByIdAsync(id);
            if (singer == null) return NotFound();
            return singer;
        }

        [HttpPost]
        public async Task<ActionResult<Singer>> Add([FromBody] SingerDTO singer)
        {
        

            Singer s = await _singerService.AddAsync(singer);
            return Ok(s);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] SingerDTO singer)
        {

            Singer s = await _singerService.UpdateAsync(id,singer);
            if (s == null)
            {
                return NotFound();
            }
            return Ok(s);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _singerService.DeleteAsync(id);
            return NoContent();
        }
    }
}
