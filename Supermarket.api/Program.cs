using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Supermarket.api.Persistence.Context;

namespace Supermarket.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            var host = BuildWebHost(args);
            using(var scope = host.Services.CreateScope())
            using(var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
              context.Database.EnsureCreated();
            }

            host.Run();

        }


        public static IWebHost BuildWebHost(string[] args) => 
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().Build();


        //Added by me
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => {
               webBuilder.UseStartup<Startup>();
           });
           


        //Added by me
        /*
        public static IHostBuilder CreateHostBuilder(string[] args) => 
            Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, service) => {
                service.AddHostedService<Worker>();
            });
        */

        /*

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
                */
    }
}
