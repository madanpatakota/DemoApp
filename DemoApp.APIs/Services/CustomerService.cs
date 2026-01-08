using DemoApp.APIs.DTOs;
using DemoApp.APIs.Entities;
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

        public async Task<CustomerReadDTO> CreateCustomerAsync(CustomerCreateDTO createDTO)
        {

            var entity = new Customer();

            entity.Name = createDTO.CustomerName;
            entity.Address = createDTO.CustomerAddress;
            entity.City = createDTO.CustomerCity;

            //Lets give this to repository to save into database

            await _customerRepository.CreateCustomerAsync(entity);  //save automaticaly ID will be generated

            var responseDTO = new CustomerReadDTO()
            {
                Id              = entity.Id,
                CustomerName    = entity.Name,
                CustomerAddress = entity.Address,
                CustomerCity    = entity.City
            };

            return responseDTO;


            //throw new NotImplementedException();
        }

        public async Task<bool> DeleteCustomerAsync(int ID)
        {
            //throw new NotImplementedException();
            var customerEntity = await _customerRepository.GetCustomerAsyncByID(ID);   // single customer data

            if (customerEntity == null)
            {
                return false;
            }

            await _customerRepository.DeleteCustomerAsync(customerEntity);  // deleting the data from database

            return true;
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

      
        public async Task<CustomerReadDTO1> GetCustomerAsyncByID(int ID)
        {
            var singelCustomerRawData = await _customerRepository.GetCustomerAsyncByID(ID);   // single customer data

            //CustomerReadDTO1 dto = new CustomerReadDTO1();
            //dto.Id = singelCustomerRawData.Id;
            //dto.CustomerName = singelCustomerRawData.Name;
            //dto.CustomerAddress = singelCustomerRawData.Address;

            CustomerReadDTO1 dto = new CustomerReadDTO1()
            {
                Id = singelCustomerRawData.Id,
                CustomerName = singelCustomerRawData.Name,
                CustomerAddress = singelCustomerRawData.Address
            };

            return dto;

        }


        
        public async Task<bool> UpdateCustomerAsync(int ID, CustomerUpdateDTO updateDTO)
        {
            //throw new NotImplementedException();

            var customerEntity = await _customerRepository.GetCustomerAsyncByID(ID);   // single customer data

            if(customerEntity == null)
            {
                return false;
            }

            customerEntity.Address = updateDTO.CustomerAddress;
            customerEntity.City    = updateDTO.CustomerCity;

            await _customerRepository.UpdateCustomerAsync(customerEntity);  // updating the data into database

            return true;

        }




        //public string abc()
        //{
        //    return "adafasd";
        //}
    }
}



// Csharp basics


