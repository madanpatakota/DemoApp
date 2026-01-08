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

        public async Task CreateCustomerAsync(Customer entity)
        {
            await _MisardTestDBContext.Customers.AddAsync(entity);
            await _MisardTestDBContext.SaveChangesAsync();
            //throw new NotImplementedException();

            //eintyt havign the ID 
        }

        public async Task DeleteCustomerAsync(Customer entity)
        {
            //throw new NotImplementedException();
            _MisardTestDBContext.Customers.Remove(entity);
            await _MisardTestDBContext.SaveChangesAsync();
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {

           return await  _MisardTestDBContext.Customers.ToListAsync();
            //throw new NotImplementedException();
        }


        public async Task<Customer> GetCustomerAsyncByID(int ID)
        {
            //return await _MisardTestDBContext.Customers.FirstOrDefaultAsync(x=>x.Id == ID);   // Customer details


            return await _MisardTestDBContext.Customers.FindAsync(ID);   // Customer details
        }

        public async Task UpdateCustomerAsync(Customer entity)
        {
            //throw new NotImplementedException();
             _MisardTestDBContext.Customers.Update(entity);
             await _MisardTestDBContext.SaveChangesAsync();
        }
    }
}
