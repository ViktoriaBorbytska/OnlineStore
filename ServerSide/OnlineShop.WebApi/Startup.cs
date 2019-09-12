using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Cors.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.BLL.ExtentionMethods;
using OnlineShop.Interfaces.DAL.Initializers;
using OnlineShop.Interfaces.DAL.Seeders;

namespace OnlineShop
{
    public class Startup
    {
        private const string AllowAnyOriginPolicyName = "AllowAnyOrigin";
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    AllowAnyOriginPolicyName,
                    builder =>
                    {
                        builder.AllowAnyOrigin().AllowAnyMethod().AllowCredentials().AllowAnyHeader();
                    });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new CorsAuthorizationFilterFactory(AllowAnyOriginPolicyName));
            });

            services.AddOnlineShop(configuration);
        }

        public void Configure (
            IApplicationBuilder applicationBuilder, 
            IHostingEnvironment hostingEnvironment,
            IDatabaseInitializer databaseInitializer,
            IDatabaseSeeder databaseSeeder)
        {
            if (hostingEnvironment.IsDevelopment())
            {
                applicationBuilder.UseDeveloperExceptionPage();
            }

            applicationBuilder.UseStaticFiles();

            applicationBuilder.UseHttpsRedirection();

            applicationBuilder.UseCors(AllowAnyOriginPolicyName);

            applicationBuilder.UseMvc(routes =>
            {
                routes.MapRoute("default", "api/{controller}/{action}/{id?}");
            });

            databaseInitializer.Initialize();
            databaseSeeder.Seed();
        }
    }
}
