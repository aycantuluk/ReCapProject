using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result =_customerService.GetAll();
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getid")]
        public IActionResult Getid(int id)
        {
            var result =_customerService.GetById(id);
            if (result.Succes)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult PostAdd(Customer customer)
        {
            var result =_customerService.Add(customer);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult PostDelete(Customer customer)
        {
            var result =_customerService.Delete(customer);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult PostUpdate(Customer customer)
        {
            var result =_customerService.Add(customer);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
