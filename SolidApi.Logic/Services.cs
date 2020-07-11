using Microsoft.Extensions.DependencyInjection;
using SolidApi.Logic.Logger;
using SolidApi.Logic.Logger.Interfaces;
using SolidApi.Logic.RentalAuthenticator;
using SolidApi.Logic.RentalAuthenticator.Interfaces;
using SolidApi.Logic.TextAdministrator;
using SolidApi.Logic.TextAdministrator.Interfaces;
using SolidApi.Repository.Database;

namespace SolidApi
{
    public static class Services
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services)
        {

            services.AddScoped<IArtAuthenticator, BookAuthenticator>();
            services.AddScoped<IArtAuthenticator, MovieAuthenticator>();
            services.AddScoped<IBookInfoProvider, BookInfoProvider>();
            services.AddScoped<IMovieInfoProvider, MovieInfoProvider>();
            services.AddScoped<IUserAuthenticator, UserAuthenticator>();
            services.AddScoped<IUserInfoProvider, UserInfoProvider>();
            services.AddScoped<IMyFactory, MyFactory>();
            services.AddTransient<TextCounter>();
            services.AddScoped<IWordsProvider, HttpWordsProvider>();
            services.AddScoped<IWordsSplitter, WordsSplitter>();
            services.AddScoped<ITextProvider, HttpTextProvider>();
            services.AddScoped<IMyLoggerFactory, MyLoggerFactory>();
            services.AddScoped<IMyLogger, ConsoleLogger>();
            services.AddScoped<IMyLogger, FileLogger>();
            services.AddHttpClient();
            services.AddScoped<IHttpClientWrapper, HttpClientWrapper>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
