using DemoApp.APIs.Entities;

namespace DemoApp.APIs.Repositoires
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllCustomersAsync();

        Task<Customer> GetCustomerAsyncByID(int ID);

        Task CreateCustomerAsync(Customer entity);

        Task UpdateCustomerAsync(Customer entity);   // i will get the all details even id is availe in this entity

        Task DeleteCustomerAsync(Customer entity);


    }
}
