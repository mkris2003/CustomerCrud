using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICustomerRepo
    {
        Task<IReadOnlyList<Customer>> GetCustomerListAsync();
        Customer GetCustomerById(int id);
        Task<Customer> CreatCustomer(Customer customer);
        Customer UpdateCustomer(Customer customer);
        Customer DeleteCustomer(int id);
    }
}
