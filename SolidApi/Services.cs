using Microsoft.Extensions.DependencyInjection;

namespace SolidApi
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddLogicServices();


            return services;
        }
    }
}
