using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OnlineShop.DAL;
using OnlineShop.Interfaces.DAL.Initializers;
using OnlineShop.DAL.Initializers;
using OnlineShop.DAL.Interfaces;
using OnlineShop.Interfaces.DAL.Seeders;
using OnlineShop.DAL.Seeders;
using OnlineShop.Interfaces.BLL;
using OnlineShop.Interfaces.DAL.Repositories;
using OnlineShop.DAL.Repositories;

namespace OnlineShop.BLL.ExtentionMethods
{
    public static class ServiceCollectionExtentionMethod
    {
        public static void AddOnlineShop(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<ApplicationDbContext>(cfg =>
            {
                cfg.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            serviceCollection.AddTransient<IDatabaseInitializer, DatabaseInitializer>();
            serviceCollection.AddTransient<IApplicationDbContext, ApplicationDbContext>();
            serviceCollection.AddTransient<IDatabaseSeeder, DatabaseSeeder>();
            serviceCollection.AddTransient<IDataService, DataService>();
            serviceCollection.AddTransient<IDataRepository, DataRepository>();
        }
    }
}
