using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.DAL.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClothingTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ColorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fashions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FashionName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fashions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SizeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClothingItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FashionID = table.Column<int>(nullable: true),
                    BrandID = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    InStock = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClothingItems_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingItems_Fashions_FashionID",
                        column: x => x.FashionID,
                        principalTable: "Fashions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClothingItemColors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClothingItemID = table.Column<int>(nullable: true),
                    ColorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingItemColors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClothingItemColors_ClothingItems_ClothingItemID",
                        column: x => x.ClothingItemID,
                        principalTable: "ClothingItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingItemColors_Colors_ColorID",
                        column: x => x.ColorID,
                        principalTable: "Colors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClothingItemSizes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClothingItemID = table.Column<int>(nullable: true),
                    SizeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingItemSizes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClothingItemSizes_ClothingItems_ClothingItemID",
                        column: x => x.ClothingItemID,
                        principalTable: "ClothingItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingItemSizes_Sizes_SizeID",
                        column: x => x.SizeID,
                        principalTable: "Sizes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClothingItemTypes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClothingItemID = table.Column<int>(nullable: true),
                    ClothingTypeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClothingItemTypes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClothingItemTypes_ClothingItems_ClothingItemID",
                        column: x => x.ClothingItemID,
                        principalTable: "ClothingItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClothingItemTypes_ClothingTypes_ClothingTypeID",
                        column: x => x.ClothingTypeID,
                        principalTable: "ClothingTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClothingItemID = table.Column<int>(nullable: true),
                    Link = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_ClothingItems_ClothingItemID",
                        column: x => x.ClothingItemID,
                        principalTable: "ClothingItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemColors_ClothingItemID",
                table: "ClothingItemColors",
                column: "ClothingItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemColors_ColorID",
                table: "ClothingItemColors",
                column: "ColorID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItems_BrandID",
                table: "ClothingItems",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItems_FashionID",
                table: "ClothingItems",
                column: "FashionID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemSizes_ClothingItemID",
                table: "ClothingItemSizes",
                column: "ClothingItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemSizes_SizeID",
                table: "ClothingItemSizes",
                column: "SizeID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemTypes_ClothingItemID",
                table: "ClothingItemTypes",
                column: "ClothingItemID");

            migrationBuilder.CreateIndex(
                name: "IX_ClothingItemTypes_ClothingTypeID",
                table: "ClothingItemTypes",
                column: "ClothingTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ClothingItemID",
                table: "Images",
                column: "ClothingItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClothingItemColors");

            migrationBuilder.DropTable(
                name: "ClothingItemSizes");

            migrationBuilder.DropTable(
                name: "ClothingItemTypes");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "ClothingTypes");

            migrationBuilder.DropTable(
                name: "ClothingItems");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Fashions");
        }
    }
}
