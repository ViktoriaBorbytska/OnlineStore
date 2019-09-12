using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL
{
    internal class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ClothingItem> ClothingItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fashion> Fashions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<ClothingType> ClothingTypes { get; set; }
        public DbSet<ClothingItemColor> ClothingItemColors { get; set; }
        public DbSet<ClothingItemSize> ClothingItemSizes { get; set; }
        public DbSet<ClothingItemType> ClothingItemTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ClothingItem>().HasKey(u => u.ID);
            builder.Entity<Brand>().HasKey(u => u.ID);
            builder.Entity<Color>().HasKey(u => u.ID);
            builder.Entity<Fashion>().HasKey(u => u.ID);
            builder.Entity<Image>().HasKey(u => u.ID);
            builder.Entity<Size>().HasKey(u => u.ID);
            builder.Entity<ClothingType>().HasKey(u => u.ID);
            builder.Entity<ClothingItemColor>().HasKey(u => u.ID);
            builder.Entity<ClothingItemSize>().HasKey(u => u.ID);
            builder.Entity<ClothingItemType>().HasKey(u => u.ID);
        }
    }
}
