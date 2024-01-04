using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application.Interfaces;

using Domain.DataBase;
using Domain.Entities;

using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreExtensions;

namespace Application.Data
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly CustomerDbContext _context;
        public CustomerRepo(CustomerDbContext customerDbContext)
        {
            _context = customerDbContext;
        }
        public async Task<Customer> CreatCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            var result =  await _context.SaveChangesAsync();
            if (result>0) { return customer; }

            return null;
        }

        public Customer DeleteCustomer(int id)
        {
            var result = GetCustomerById(id);
            _context.Customers.Remove(result);
            _context.SaveChanges();
            return result;
        }

        public  Customer GetCustomerById(int id)
        {
           return _context.Customers.FindAsync(id).Result;
        }

        public async Task<IReadOnlyList<Customer>> GetCustomerListAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public Customer UpdateCustomer(Customer customer)
        {
            var exsitCustomer = GetCustomerById(customer.ID);
            exsitCustomer.FirstName = customer.FirstName;
            exsitCustomer.LastName = customer.LastName;
            exsitCustomer.Email = customer.Email;
            _context.SaveChanges();
            return customer;
        }

        
    }
}


//dotnet ef migrations add InitalCreateCustomerDbContext  --context CustomerDbContext  -- "Data Source=DESKTOP-FDHO0L4;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
// pacakge manger
//Add-Migration InitalCreateCustomerDbContext -Args  "Data Source=DESKTOP-FDHO0L4;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False" -context CustomerDbContext 
// powrswhel
// dotnet ef database update 20240103013311_InitalCreateCustomerDbContext --context CustomerDbContext   -- "Data Source=DESKTOP-FDHO0L4;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"
//dotnet ef database update 20240103015916_InitalDataInsertCustomerDbContext --context CustomerDbContext   -- "Data Source=DESKTOP-FDHO0L4;Initial Catalog=CustomerDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False" 
// https://stackblitz.com/edit/angular-crud-example-with-mock-services?file=src%2Fapp%2Fcomponents%2Fnavigation-bar%2Fnavigation-bar.component.html

//https://stackblitz.com/edit/github-ngrx-crud?file=README.md
//https://labpys.com/how-to-create-crud-operation-using-angular-and-asp-net-core-web-api/