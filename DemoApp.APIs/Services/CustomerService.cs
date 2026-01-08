using DemoApp.APIs.DTOs;
using DemoApp.APIs.Repositoires;

namespace DemoApp.APIs.Services
{
    public class CustomerService : ICustomerService
    {

        //repo injection

        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }




        public async Task<List<CustomerReadDTO>> GetAllCustomersAsync()
        {
            var RawTotalData =  await  _customerRepository.GetAllCustomersAsync();   // list of data Customer format


            var names =  RawTotalData.Select(x => x.Name);   // Names  // select name from Customer


            var mydatasomethig = RawTotalData.Select(x => new { CustomerNames = x.Name , customersowncities = x.City });  // CustomerNames --


           var filterData =  RawTotalData.Select(x=> new CustomerReadDTO
            {
                Id = x.Id,
                CustomerAddress = x.Address,   //cutomeraddresss is null
                CustomerName = x.Name,
                CustomerCity = x.City
            });


            return filterData.ToList();
            //throw new NotImplementedException();


            // I need to convert Csutomer to CustomerReadDTO
        }



        //public string abc()
        //{
        //    return "adafasd";
        //}
    }
}



// Csharp basics


