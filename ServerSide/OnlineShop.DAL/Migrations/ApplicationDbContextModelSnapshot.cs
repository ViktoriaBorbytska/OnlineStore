﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShop.DAL;

namespace OnlineShop.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShop.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName");

                    b.HasKey("ID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandID");

                    b.Property<string>("Description");

                    b.Property<int?>("FashionID");

                    b.Property<bool>("InStock");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.HasIndex("BrandID");

                    b.HasIndex("FashionID");

                    b.ToTable("ClothingItems");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemColor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothingItemID");

                    b.Property<int?>("ColorID");

                    b.HasKey("ID");

                    b.HasIndex("ClothingItemID");

                    b.HasIndex("ColorID");

                    b.ToTable("ClothingItemColors");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemSize", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothingItemID");

                    b.Property<int?>("SizeID");

                    b.HasKey("ID");

                    b.HasIndex("ClothingItemID");

                    b.HasIndex("SizeID");

                    b.ToTable("ClothingItemSizes");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothingItemID");

                    b.Property<int?>("ClothingTypeID");

                    b.HasKey("ID");

                    b.HasIndex("ClothingItemID");

                    b.HasIndex("ClothingTypeID");

                    b.ToTable("ClothingItemTypes");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName");

                    b.HasKey("ID");

                    b.ToTable("ClothingTypes");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.Color", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColorName");

                    b.HasKey("ID");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.Fashion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FashionName");

                    b.HasKey("ID");

                    b.ToTable("Fashions");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.Image", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClothingItemID");

                    b.Property<string>("Link");

                    b.HasKey("ID");

                    b.HasIndex("ClothingItemID");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.Size", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SizeName");

                    b.HasKey("ID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItem", b =>
                {
                    b.HasOne("OnlineShop.DAL.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID");

                    b.HasOne("OnlineShop.DAL.Entities.Fashion", "Fashion")
                        .WithMany()
                        .HasForeignKey("FashionID");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemColor", b =>
                {
                    b.HasOne("OnlineShop.DAL.Entities.ClothingItem", "ClothingItem")
                        .WithMany()
                        .HasForeignKey("ClothingItemID");

                    b.HasOne("OnlineShop.DAL.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorID");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemSize", b =>
                {
                    b.HasOne("OnlineShop.DAL.Entities.ClothingItem", "ClothingItem")
                        .WithMany()
                        .HasForeignKey("ClothingItemID");

                    b.HasOne("OnlineShop.DAL.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.ClothingItemType", b =>
                {
                    b.HasOne("OnlineShop.DAL.Entities.ClothingItem", "ClothingItem")
                        .WithMany()
                        .HasForeignKey("ClothingItemID");

                    b.HasOne("OnlineShop.DAL.Entities.ClothingType", "ClothingType")
                        .WithMany()
                        .HasForeignKey("ClothingTypeID");
                });

            modelBuilder.Entity("OnlineShop.DAL.Entities.Image", b =>
                {
                    b.HasOne("OnlineShop.DAL.Entities.ClothingItem", "ClothingItem")
                        .WithMany()
                        .HasForeignKey("ClothingItemID");
                });
#pragma warning restore 612, 618
        }
    }
}
