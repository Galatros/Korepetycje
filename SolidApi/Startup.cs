using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using SolidApi.Classes;
using SolidApi.Infrastructure;
using SolidApi.Infrastructure.Logger;
using SolidApi.Interfaces;
using SolidApi.RentalAuthenticator;
using System;

namespace SolidApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddHttpClient();
            services.AddServices();
        }

        /*
         * IQuerable
         * 1. DbContext.Get<Workers>  select * from Workers
         * 2. .Where(w => w.Position == "engienier") where Worker.Position = "enignier"
         * 3. .Where(w => w.Age > 60) where Worker.Age > 60
         * 
         * query.ToListAsync()  select * from Workers where Worker.Position = "enignier" and Worker.Age > 60
         */

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = String.Empty;
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
