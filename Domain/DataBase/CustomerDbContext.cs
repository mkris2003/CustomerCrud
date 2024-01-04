using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Domain.DataBase
{
    public class CustomerDbContext : DbContext
    {
        private  string _connectionString;
        public CustomerDbContext()
        {

        }
        public CustomerDbContext( string connectionString)
        {
            _connectionString=connectionString;
        }
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
              .HasKey(p => new { p.ID });
        }
    }
}
