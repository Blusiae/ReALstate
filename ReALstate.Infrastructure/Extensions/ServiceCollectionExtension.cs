using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReALstate.Domain.Interfaces.Repositories;
using ReALstate.Infrastructure.DbContext;
using ReALstate.Infrastructure.Repositories;

namespace ReALstate.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        // AddInfrastructure method is an extension method for IServiceCollection, it was made for the code to be more clear and divided 
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Get the connection string from appsettings.json
            var connectionString = configuration.GetConnectionString("ReALstateDb");

            // Add the DbContext to the services
            services.AddDbContext<EstatesDbContext>(options =>
                options.UseSqlServer(connectionString));

            // Add the repositories to the services
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IEstateRepository, EstateRepository>();
            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IHouseRepository, HouseRepository>();
            services.AddScoped<IOfferRepository, OfferRepository>();

        }
    }
}
