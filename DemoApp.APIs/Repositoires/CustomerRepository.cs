using DemoApp.APIs.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoApp.APIs.Repositoires
{
    public class CustomerRepository : ICustomerRepository
    {

        MisardTestDBContext _MisardTestDBContext;

        public CustomerRepository(MisardTestDBContext misardTestDBContext) {
            _MisardTestDBContext = misardTestDBContext;
        }


       
        public async Task<List<Customer>> GetAllCustomersAsync()
        {

           return await  _MisardTestDBContext.Customers.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}
