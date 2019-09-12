using OnlineShop.DAL.Interfaces;
using OnlineShop.Interfaces.DAL.Initializers;
using OnlineShop.Interfaces.DAL.Seeders;

namespace OnlineShop.DAL.Initializers
{
    internal class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly IApplicationDbContext context;

        public DatabaseInitializer(IApplicationDbContext context)
        {
            this.context = context;
        }

        public void Initialize()
        {
            context.Database.EnsureCreated();
        }
    }
}
