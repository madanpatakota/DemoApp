using DemoApp.APIs.DTOs;
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



        //endpoint: https://localhost:7199/api/Customer/GetCustomers
        [HttpGet("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var data = await _customerService.GetAllCustomersAsync();
            return data is null ? NotFound() : Ok(data);
        }




        //Lets prepare the endpoint to get the customer based on the ID ---
        //
        // Inserting the data into the database always ID is the unique


        [HttpGet("GetCustomerBYID/{ID:int}")]
        public async Task<IActionResult> GetCustomerBYID(int ID)
        {
            var data = await _customerService.GetCustomerAsyncByID(ID);
            return data is null ? NotFound() : Ok(data);
        }




        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDTO creteDTO)
        {
            var result = await _customerService.CreateCustomerAsync(creteDTO);
            return result is null ? BadRequest() : Ok(result);
        }


        //post method post payload , put payload 

        [HttpPost("UpdateCustomer/{ID}")]
        public async Task<IActionResult> UpdateCustomer(int ID, [FromBody] CustomerUpdateDTO updateDTO)
        {
            //call the service to update the customer
            //var result = await _customerService.UpdateCustomerAsync(ID, updateDTO);
            //return result is null ? BadRequest() : Ok(result);
            //return Ok();

            var result = await _customerService.UpdateCustomerAsync(ID, updateDTO);

            return result ? Ok() : BadRequest(); // return appropriate response based on result
        }



        [HttpDelete("DeleteCustomer/{ID}")]
        public async Task<IActionResult> DeleteCustomer(int ID)
        {

            var result = await _customerService.DeleteCustomerAsync(ID);
            return result ? Ok() : BadRequest();

        }
    }
}


