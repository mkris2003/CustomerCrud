using Domain.Entities;

using Infrastructure.Interfaces;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {
                var result =await _customerService.GetCustomerListAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}",Name = "GetCustomerById")]
        public IActionResult GetCustomerById(int id)
        {
            try
            {
                var result =  _customerService.GetCustomerById(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost(Name = "CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(Customer customer)
        {
            try
            {
                var result = await _customerService.CreatCustomer(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut(Name = "UpdateCustomer")]
        public IActionResult UpdateCustomer(Customer customer)
        {
            try
            {
                var result =  _customerService.UpdateCustomer(customer);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpDelete("{id}",Name = "DeleteCustomer")]
        public IActionResult DeleteCustomer(int id)
        {
            try
            {
                var result = _customerService.DeleteCustomer(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
