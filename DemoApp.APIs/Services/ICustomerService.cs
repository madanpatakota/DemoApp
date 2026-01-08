using DemoApp.APIs.DTOs;
using DemoApp.APIs.Entities;

namespace DemoApp.APIs.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerReadDTO>> GetAllCustomersAsync();
    }
}
