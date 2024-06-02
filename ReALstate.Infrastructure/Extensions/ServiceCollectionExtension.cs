using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReALstate.Infrastructure.DbContext;

namespace ReALstate.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("ReALstateDb");

            services.AddDbContext<EstatesDbContext>(options =>
                options.UseSqlServer(connectionString));

        }
    }
}
