//responsible for configuring all the configurations when the program starts.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Supermarket.api.Domain.Repositories;
using Supermarket.api.Domain.Services;
using Supermarket.api.Persistence.Context;
using Supermarket.api.Persistence.Repositories;
using Supermarket.api.Services;

//using Microsoft.Extensions.Hosting;

using Microsoft.Extensions.IHostEnvironment;

//using Microsoft.AspNetCore.Hosting.IWebHostingEnvironment;
//using Microsoft.Extensions.Hosting.IHostApplicationLifetime;
//using Microsoft.Extensions.Hosting.Environments;


namespace Supermarket.api
{
    public class Startup
    {


        /*
        internal class HostingEnvironment : IHostEnvironment, Extensions.Hosting.IHostEnvironment, IWebHostingEnvironment
        {
            public string Environment { get; set; } = Extensions.Hosting.Environments.Production;
            public string ApplicationName { get; set; }
            public string WebRootPath { get; set; }
            public IFileProvider WebRootPath { get; set; }
            public string ContentRootPath { get; set; }
            public IFilePorvider ContentRootFileProvider { get; set; }
        }

        */

        //public interface IWebHostingEnvironment : Microsoft.Extensions.Hosting.IHostEnvironment{}
        public interface IHostEnvironment{}
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc =("v1", new OpenApiInfo
                {
                    Title = "My Awesome API",
                    Version = "v1"
                });
            });


            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemorydatabase("supermarket-api-in-memory");
            });
            //we are telling the ASP.NET Core to use our AppDbcontext with
            //an in memory database implementation

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();



            /*
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Supermarket.api", Version = "v1" });
            }); */

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                /*
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Supermarket.api v1"));

                */
            }
            else
            {

                app.UseHsts();

            }

            app.UseHttpsRedirection();
            app.UseMvc();

            /*

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            */
        }
    }
}


//Dependanyc Injection technique advantages:

/*
-Code Reusability
-Better Productivity
-Easly testing the application
-haga kaman tawela keda
*/

