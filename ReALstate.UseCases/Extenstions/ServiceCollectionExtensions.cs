using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace ReALstate.UseCases.Extenstions
{
    // Extension method to add use cases to the service collection
    public static class ServiceCollectionExtensions
    {
        public static void AddUseCases(this IServiceCollection services)
        {
            // Get the assembly of the current class
            var assembly = typeof(ServiceCollectionExtensions).Assembly;

            // Add MediatR, AutoMapper, FluentValidation, and UserContext to the service collection
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assembly));
            services.AddAutoMapper(assembly);
            services.AddValidatorsFromAssembly(assembly).AddFluentValidationAutoValidation();

            //services.AddScoped<IUserContext, UserContext>();

            //services.AddHttpContextAccessor();
        }
    }
}
