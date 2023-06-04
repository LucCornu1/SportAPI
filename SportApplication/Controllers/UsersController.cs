using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SportApplication.Models;
using SportApplication.Services.UserServices;
using System.Diagnostics;

namespace SportApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> GetUsers()
        {
            var result = _userService.GetUsers();

            return Ok(result);
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<User>> GetUser(string email)
        {
            var result = _userService.GetUser(email);

            return result == null ? NotFound("User not found") : Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User newUser)
        {
            var result = _userService.AddUser(newUser);

            return Ok(result);
        }

        [HttpPut("{email}")]
        public async Task<ActionResult<User>> UpdateUser(string email, User updatedUser)
        {
            var result = _userService.UpdateUser(email, updatedUser);

            return result == null ? NotFound("User not found") : CreatedAtAction(nameof(GetUser), new { email = result.Email }, result);
        }

        [HttpDelete("{email}")]
        public async Task<ActionResult<User>> DeleteUser(string email)
        {
           var result = _userService.DeleteUser(email);

           return !result ? NotFound("User not found") : Ok();
        }
    }
}
