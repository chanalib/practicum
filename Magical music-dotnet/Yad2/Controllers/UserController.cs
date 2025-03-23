using AutoMapper;
using MagicalMusic.CORE.DTOs;
using MagicalMusic.CORE.Models;
using MagicalMusic.CORE.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MagicalMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        private readonly ILogger<UserController> _logger;

        public UserController(IUserService userService, ILogger<UserController> logger)
        {
            _userService = userService;
            _logger = logger;
        }

       // [Authorize(policy: "AdminOnly")]
        [HttpGet]
        public async Task<IEnumerable<User>> GetAll()
        {
            _logger.LogInformation("Admin user accessed GetAll method.");
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
        public async Task<ActionResult<User>> Add([FromBody] UserDTO userDto)
        {
            var user = await _userService.AddAsync(userDto);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }



        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] UserDTO user)
        {
            User u = await _userService.UpdateAsync(id, user);
            if (u == null)
            {
                return NotFound();
            }
            return Ok(u);
        }
   //     [Authorize(policy: "EditorOrAdmin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userService.DeleteAsync(id);
            return NoContent();
        }
    }
}