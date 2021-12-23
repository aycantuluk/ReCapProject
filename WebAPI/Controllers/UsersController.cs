using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Entities.Concreate;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService= userService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getid")]
        public IActionResult Getid(int id)
        {
            var result = _userService.GetById(id);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult PostAdd(User user)
        {
            var result = _userService.Add(user);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult PostDelete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult PostUpdate(User user)
        {
            var result = _userService.Add(user);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
