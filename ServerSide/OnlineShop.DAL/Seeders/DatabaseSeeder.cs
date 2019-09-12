using OnlineShop.DAL.Entities;
using OnlineShop.DAL.Interfaces;
using OnlineShop.Interfaces.DAL.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.DAL.Seeders
{
    internal class DatabaseSeeder : IDatabaseSeeder
    {
        private const string DESCR = "This is DESIGN – your go-to for all the" +
                " latest trends, no matter who you are, where you’re from " +
                "and what you’re up to. Exclusive to, our universal " +
                "brand is here for you, and comes in all our fit ranges: Curve, " +
                "Tall, Petite and Maternity. Created by us, styled by you.";

        private readonly IApplicationDbContext context;

        private List<Brand> brands;
        private List<Fashion> fashions;
        private List<ClothingItem> clothingItems;
        private List<Image> images;

        public DatabaseSeeder(IApplicationDbContext context)
        {
            this.context = context;
        }

        public void Seed()
        {
            brands = new List<Brand>();
            fashions = new List<Fashion>();
            clothingItems = new List<ClothingItem>();
            images = new List<Image>();

            CreateBrands();

            CreateFashions();

            CreateClothingItems();

            CreateImages();

            context.Brands.AddRange(brands);
            context.Fashions.AddRange(fashions);
            context.ClothingItems.AddRange(clothingItems);
            context.Images.AddRange(images);

            context.SaveChanges();
        }

        private void CreateBrands()
        {
            brands.Add(new Brand { BrandName = "Armani" });
            brands.Add(new Brand { BrandName = "Burbary" });
            brands.Add(new Brand { BrandName = "Nike" });
            brands.Add(new Brand { BrandName = "Adidas" });
            brands.Add(new Brand { BrandName = "Ralph Lauren" });
            brands.Add(new Brand { BrandName = "Prada" });
            brands.Add(new Brand { BrandName = "Off White" });
            brands.Add(new Brand { BrandName = "Balenciaga" });
            brands.Add(new Brand { BrandName = "Levi's" });
            brands.Add(new Brand { BrandName = "Tommy Hilfiger" });
        }

        private void CreateFashions()
        {
            fashions.Add(new Fashion { FashionName = "Smart Casual" });
            fashions.Add(new Fashion { FashionName = "Casual" });
            fashions.Add(new Fashion { FashionName = "Sports" });
        }

        private void CreateClothingItems()
        {
            // New arrivals
            clothingItems.Add(new ClothingItem
            {
                Name = "Straight Leg Jeans",
                Price = 55m,
                Brand = brands[0],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Boyfriend T-Shirt with Bohemian Print",
                Price = 34.25m,
                Brand = brands[4],
                InStock = true,
                Fashion = fashions[1],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Only Busted Knee Jean",
                Price = 140.50m,
                Brand = brands[5],
                InStock = true,
                Fashion = fashions[1],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Only Skinny Jeans",
                Price = 12.75m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            // Catalog

            clothingItems.Add(new ClothingItem
            {
                Name = "Only Skinny Jeans",
                Price = 65.5m,
                Brand = brands[3],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Boyfriend T-shirt with Bohemian Print",
                Price = 76.25m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Turtle Neck Jumper in Rib",
                Price = 130.25m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "With Patchwork Crochet",
                Price = 80.6m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Levi's Jeans for women",
                Price = 120.75m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Boyfriend T-Shirt with Bohemian Print",
                Price = 90m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Colour Block",
                Price = 550.5m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Monki Festval Knitted",
                Price = 24.75m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Oversized Cardigan",
                Price = 90m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Paul & Joe Sister Jumper with Neon Trims",
                Price = 19.75m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Only Busted Knee Jean",
                Price = 140.5m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });

            clothingItems.Add(new ClothingItem
            {
                Name = "Boyfriend T-Shirt with Bohemian Print",
                Price = 85.75m,
                Brand = brands[8],
                InStock = true,
                Fashion = fashions[0],
                Description = DESCR
            });
        }

        private void CreateImages()
        {
            const int numberOfItems = 16;

            for (int i = 0; i < numberOfItems; i++)
            {
                CreateImage(i);
            }
        }

        private void CreateImage(int itemId)
        {
            images.Add(new Image
            {
                Link = $"/clothing_items/{itemId + 1}/1.png",
                ClothingItem = clothingItems[itemId]
            });
        }
    }
}
