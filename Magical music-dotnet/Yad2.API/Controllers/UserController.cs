using Microsoft.AspNetCore.Mvc;
using Music.Core.Models;
using Music.Core.Services;
using Music.Service;
using Music.Core.Dtos;
using Microsoft.AspNetCore.Authorization;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Music.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize(policy: "AdminOnly")]
        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id)
        {
            var user = await _userService.GetByIdAsync(id);
            if (user == null) return NotFound();
            return user;
        }
        [HttpPost]
        public async Task<ActionResult<Singer>> Add([FromBody] UserDTO user)
        {
            User u = await _userService.AddAsync(user);
            return Ok(u);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserDTO user)
        {
            User u = await _userService.UpdateAsync(id,user);
            if (u == null)
            {
                return NotFound();
            }
            return Ok(u);
        }
        [Authorize(policy: "EditorOrAdmin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}
