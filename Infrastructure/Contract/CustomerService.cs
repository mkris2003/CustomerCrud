using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Contract
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo customerRepo)
        {
            _customerRepo= customerRepo;
        }
        public async Task<Customer> CreatCustomer(Customer customer)
        {
            return  await _customerRepo.CreatCustomer(customer);
        }

        public Customer DeleteCustomer(int id)
        {
           return _customerRepo.DeleteCustomer(id);
        }

        public Customer GetCustomerById(int id)
        {
          return  _customerRepo.GetCustomerById(id);
        }

        public async Task<IReadOnlyList<Customer>> GetCustomerListAsync()
        {
           return await _customerRepo.GetCustomerListAsync();
        }

        public Customer UpdateCustomer(Customer customer)
        {
           return _customerRepo.UpdateCustomer(customer);
        }
    }
}
