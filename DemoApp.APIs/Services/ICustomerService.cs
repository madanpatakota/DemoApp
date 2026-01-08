using DemoApp.APIs.DTOs;
using DemoApp.APIs.Entities;

namespace DemoApp.APIs.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerReadDTO>> GetAllCustomersAsync();

        Task<CustomerReadDTO1> GetCustomerAsyncByID(int ID);


        Task<CustomerReadDTO> CreateCustomerAsync(CustomerCreateDTO createDTO);

        Task<bool> UpdateCustomerAsync(int ID, CustomerUpdateDTO updateDTO);

        Task<bool> DeleteCustomerAsync(int ID);

    }
}
