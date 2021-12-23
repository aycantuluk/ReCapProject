using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carSevice;
        public CarsController(ICarService carSevice)
        {
            _carSevice = carSevice;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result=_carSevice.GetAll();
            if(result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getid")]
        public IActionResult GetId(int id)
        {
            var result = _carSevice.GetById(id);
            if(result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult PostAdd(Car car)
        {
            var result = _carSevice.Add(car);
            if(result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult PostDelete(Car car)
        {
            var result = _carSevice.Delete(car);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult PostUpdate(Car car)
        {
            var result = _carSevice.Update(car);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
