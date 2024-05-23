using TechChallenge1.Data.Repository;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Services;


namespace TechChallenge1.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IContactService, ContactService>();
            services.AddScoped<IContactRepository, ContactRepository>();
            services.AddScoped<IStateRepository, StateRepository>();
            services.AddScoped<IStateService, StateService>();

            return services;
        }
    }
}
