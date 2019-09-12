using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OnlineShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Interfaces
{
    internal interface IApplicationDbContext
    {
        DbSet<ClothingItem> ClothingItems { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Fashion> Fashions { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<Size> Sizes { get; set; }
        DbSet<ClothingType> ClothingTypes { get; set; }
        DbSet<ClothingItemColor> ClothingItemColors { get; set; }
        DbSet<ClothingItemSize> ClothingItemSizes { get; set; }
        DbSet<ClothingItemType> ClothingItemTypes { get; set; }
        DatabaseFacade Database { get; }

        int SaveChanges();
    }
}
