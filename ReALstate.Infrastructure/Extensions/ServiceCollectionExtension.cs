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
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ReALstateDb");

            services.AddDbContext<EstatesDbContext>(options =>
                options.UseSqlServer(connectionString));


            services.AddScoped<IEstateOwnerRepository, EstateOwnerRepository>();
            services.AddScoped<IEstateRepository, EstateRepository>();

        }
    }
}
