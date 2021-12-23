using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;   
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_colorService.GetAll();
            if(result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getid")]
        public IActionResult Getid(int id)
        {
            var result = _colorService.GetById(id);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult PostAdd(Color color)
        {
            var result=_colorService.Add(color);
            if(result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult PostDelete(Color color)
        {
            var result = _colorService.Delete(color);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult PostUpdate(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
