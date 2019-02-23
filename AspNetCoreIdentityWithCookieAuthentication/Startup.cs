using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreIdentityWithCookieAuthentication.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreIdentityWithCookieAuthentication
{
    public class Startup
    {
        private readonly IConfiguration _config;
        //You can constructor inject this service so that it can be used in the start up class to 
        //get configurations from the sources like appsettings.json
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvcCore().AddAuthorization();
            services.AddMvc();

            //string connectionString = @"Server=.\SQLEXPRESS;Database=MovieDB;Trusted_Connection=true;";
            services.AddDbContext<MovieDbContext>((options) => options.UseSqlServer(_config["ConnectionString"]));

            services.AddIdentity<User, IdentityRole>()
                    .AddEntityFrameworkStores<MovieDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseNodeModules(env);

            app.UseAuthentication();
            
            app.UseMvc(ConfigureRoute);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("You have reached to the end of the Middleware Chain, that  means none of the " +
                    "other Middleware has worked, Contact your Admin");
            });
        }

        private void ConfigureRoute(IRouteBuilder routeBuilder)
        {
            //You can define as many routes as required here

            //Default router should be at the end
            routeBuilder.MapRoute("Default", "{Controller=Home}/{Action=Index}/{Id?}");
        }
    }
}
