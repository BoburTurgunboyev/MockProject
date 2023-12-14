using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MockProject.Dtos;
using MockProject.Services;

namespace MockProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUserAsync( UserDto userDto)
        {
            var res = await _userService.CreateUserAsync(userDto);
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllAsync()
        {
            var res = await _userService.GetAllAsync();
            return Ok(res);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetByIdAsync(int Id) 
        {
            var res = await _userService.GetByIdAsync(Id);
            return Ok(res);
        }

        [HttpPut]

        public async ValueTask<IActionResult> UpdateUserAsync(int Id, UserDto userDto)
        {
            var res = await _userService.UpdateUserAsync(Id,userDto);
            return Ok(res);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteUserAsync(int Id)
        {
            var res = await _userService.DeleteUserAsync(Id);
            return Ok(res);
        }
    }
}
