using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Post(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult PostUpdate(Brand brand)
        {
            var result = _brandService.Update(brand);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("Delete")]
        public IActionResult PostDelete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
