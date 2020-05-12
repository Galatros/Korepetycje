using Microsoft.Extensions.DependencyInjection;
using SolidApi.Classes;
using SolidApi.Interfaces;
using SolidApi.RentalAuthenticator;

namespace SolidApi
{
    public static class Services
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services)
        {
            services.AddScoped<IArtAuthenticator, BookAuthenticator>();
            services.AddScoped<IBookInfoProvider, BookInfoProvider>();
            services.AddScoped<IUserAuthenticator, UserAuthenticator>();
            services.AddScoped<IUserInfoProvider, UserInfoProvider>();
            services.AddScoped<IMyFactory, MyFactory>();

            return services;
        }
    }
}
