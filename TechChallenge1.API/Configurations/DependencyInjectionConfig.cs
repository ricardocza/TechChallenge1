using System.Runtime.CompilerServices;
using TechChallenge1.Data.Repository;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Services;
using TechChallenge1.Infrastructure.Interfaces;
using TechChallenge1.Infrastructure.Repository;

namespace TechChallenge1.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();

            return services;
        }
    }
}
