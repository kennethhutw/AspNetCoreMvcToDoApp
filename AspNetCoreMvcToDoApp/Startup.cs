// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Builder;
// using Microsoft.AspNetCore.Hosting;
// using Microsoft.Extensions.Configuration;
// using Microsoft.Extensions.DependencyInjection;
// using Microsoft.Extensions.Logging;

// namespace AspNetCoreToDoApp
// {
//     using System.Reflection;
//     using AspNetCoreToDoApp.Web.Models;
//     using AutoMapper;
//     using MeediatR;
//     using Microsoft.EntityFrameworkCore;
//     public class Startup
//     {
//         public Startup(IHostingEnvironment env)
//         {
//             var builder = new ConfigurationBuilder()
//                 .SetBasePath(env.ContentRootPath)
//                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//                 .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
//                 .AddEnvironmentVariables();
//             Configuration = builder.Build();
//         }

//         public IConfigurationRoot Configuration { get; }

//         // This method gets called by the runtime. Use this method to add services to the container.
//         public void ConfigureServices(IServiceCollection services)
//         {
//             // Add framework services.
//             services.AddMvc();
//         }

//         // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//         public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
//         {
//             loggerFactory.AddConsole(Configuration.GetSection("Logging"));
//             loggerFactory.AddDebug();

//             if (env.IsDevelopment())
//             {
//                 app.UseDeveloperExceptionPage();
//                 app.UseBrowserLink();
//             }
//             else
//             {
//                 app.UseExceptionHandler("/Home/Error");
//             }

//             app.UseStaticFiles();

//             app.UseMvc(routes =>
//             {
//                 routes.MapRoute(
//                     name: "default",
//                     template: "{controller=Home}/{action=Index}/{id?}");
//             });
//         }
//     }
// }


namespace AspNetCoreToDoApp.Web
{
    using System.Reflection;
    using AspNetCoreToDoApp.Web.Models;
    using AutoMapper;
    using MediatR;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = @"Server=.\SQLEXPRESS;Database=AspNetCoreToDo;Trusted_Connection=True;";
            services.AddDbContext<ToDoContext>(options => options.UseSqlServer(connection));

            services.AddSession();
            services.AddMvc();
            services.AddAutoMapper(GetExecutingAssembly());
            services.AddMediatR(GetExecutingAssembly());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static Assembly GetExecutingAssembly()
        {
            return typeof(Startup).GetTypeInfo().Assembly;
        }
    }
}