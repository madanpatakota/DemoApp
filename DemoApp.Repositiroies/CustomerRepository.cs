using DemoApp.APIs.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace DemoApp.APIs.Repositoires
{
    public class CustomerRepository : ICustomerRepository
    {

        MisardTestDBContext _MisardTestDBContext;

        public CustomerRepository(MisardTestDBContext misardTestDBContext) {
            _MisardTestDBContext = misardTestDBContext;
        }

        //public async Task<Customer> GetAllCustomerAsyncByID(int ID)
        //{
        //    return await _MisardTestDBContext.Customers.FirstOrDefaultAsync(x => x.Id == ID);
        //    //throw new NotImplementedException();
        //}

        public async Task<Customer> GetCustomerAsyncByID(int ID)
        {
            //return await _MisardTestDBContext.Customers.FirstOrDefaultAsync(x=>x.Id == ID);   // Customer details


            return await _MisardTestDBContext.Customers.FindAsync(ID);   // Customer details
        
        }



        public async Task<List<Customer>> GetAllCustomersAsync()
        {

           return await  _MisardTestDBContext.Customers.ToListAsync();
            //throw new NotImplementedException();
        }
    }
}
