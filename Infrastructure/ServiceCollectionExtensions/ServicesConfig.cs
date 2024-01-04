using Application.Data;
using Application.Interfaces;
using Domain.DataBase;
using Infrastructure.Contract;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.ServiceCollectionExtensions
{
    public static class ServicesConfig
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration config)
        {
            var connectionstring = config.GetConnectionString("CustomerDatabase");
            services.AddDbContext<CustomerDbContext>(opt =>
            {
                opt.UseSqlServer(connectionstring);
            });

            services.AddScoped<ICustomerRepo, CustomerRepo>();
            services.AddScoped<ICustomerService, CustomerService>();

            return services;
        }
    }
}
