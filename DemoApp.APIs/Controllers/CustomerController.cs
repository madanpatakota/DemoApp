using DemoApp.APIs.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.APIs.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }



        //endpoint: https:locahost:7199/api/Customer/GetCustomers
        [HttpGet("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var data = await _customerService.GetAllCustomersAsync();
            return data is null ? NotFound() : Ok(data);
        }


    }
}


