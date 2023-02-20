using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyFirstConsoleApp
{
    internal class Startup
    {
        public void ConfigurationService(IServiceCollection service)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(endPoints=>
            {
                endPoints.MapGet("/",async context =>
                {
                    await context.Response.WriteAsync("Hello From WebGentle Application!");
                });
            }); 

        }
    }
}