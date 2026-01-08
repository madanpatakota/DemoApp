using DemoApp.APIs.Entities;

namespace DemoApp.APIs.Repositoires
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();
    }
}
