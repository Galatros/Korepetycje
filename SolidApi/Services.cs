using Microsoft.Extensions.DependencyInjection;
using SolidApi.Classes;
using SolidApi.Infrastructure;
using SolidApi.Infrastructure.Logger;
using SolidApi.Interfaces;
using SolidApi.RentalAuthenticator;

namespace SolidApi
{
    public static class Services
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<TextCounter>();
            services.AddScoped<IWordsProvider, HttpWordsProvider>();
            services.AddScoped<IWordsSplitter, WordsSplitter>();
            services.AddScoped<ITextProvider, HttpTextProvider>();
            services.AddScoped<IHttpClientWrapper, HttpClientWrapper>();
            services.AddScoped<IMyLoggerFactory, MyLoggerFactory>();
            services.AddScoped<IMyLogger, ConsoleLogger>();
            services.AddScoped<IMyLogger, FileLogger>();

            services.AddLogicServices();

            return services;
        }
    }
}
