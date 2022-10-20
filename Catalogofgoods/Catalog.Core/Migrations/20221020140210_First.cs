using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catalog.Core.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    BuyerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.BuyerId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Goodes",
                columns: table => new
                {
                    GoodsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goodes", x => x.GoodsId);
                });

            migrationBuilder.CreateTable(
                name: "Sellers",
                columns: table => new
                {
                    SellerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SellerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sellers", x => x.SellerId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrandGoods",
                columns: table => new
                {
                    BrandsBrandId = table.Column<int>(type: "int", nullable: false),
                    GoodesGoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandGoods", x => new { x.BrandsBrandId, x.GoodesGoodsId });
                    table.ForeignKey(
                        name: "FK_BrandGoods_Brands_BrandsBrandId",
                        column: x => x.BrandsBrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandGoods_Goodes_GoodesGoodsId",
                        column: x => x.GoodesGoodsId,
                        principalTable: "Goodes",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuyerGoods",
                columns: table => new
                {
                    BuyersBuyerId = table.Column<int>(type: "int", nullable: false),
                    GoodesGoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyerGoods", x => new { x.BuyersBuyerId, x.GoodesGoodsId });
                    table.ForeignKey(
                        name: "FK_BuyerGoods_Buyers_BuyersBuyerId",
                        column: x => x.BuyersBuyerId,
                        principalTable: "Buyers",
                        principalColumn: "BuyerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyerGoods_Goodes_GoodesGoodsId",
                        column: x => x.GoodesGoodsId,
                        principalTable: "Goodes",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryGoods",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    GoodesGoodsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryGoods", x => new { x.CategoriesCategoryId, x.GoodesGoodsId });
                    table.ForeignKey(
                        name: "FK_CategoryGoods_Categories_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryGoods_Goodes_GoodesGoodsId",
                        column: x => x.GoodesGoodsId,
                        principalTable: "Goodes",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodsSeller",
                columns: table => new
                {
                    GoodesGoodsId = table.Column<int>(type: "int", nullable: false),
                    SellersSellerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsSeller", x => new { x.GoodesGoodsId, x.SellersSellerId });
                    table.ForeignKey(
                        name: "FK_GoodsSeller_Goodes_GoodesGoodsId",
                        column: x => x.GoodesGoodsId,
                        principalTable: "Goodes",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsSeller_Sellers_SellersSellerId",
                        column: x => x.SellersSellerId,
                        principalTable: "Sellers",
                        principalColumn: "SellerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GoodsType",
                columns: table => new
                {
                    GoodesGoodsId = table.Column<int>(type: "int", nullable: false),
                    TypesTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsType", x => new { x.GoodesGoodsId, x.TypesTypeId });
                    table.ForeignKey(
                        name: "FK_GoodsType_Goodes_GoodesGoodsId",
                        column: x => x.GoodesGoodsId,
                        principalTable: "Goodes",
                        principalColumn: "GoodsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsType_Types_TypesTypeId",
                        column: x => x.TypesTypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a2203cc7-160b-43b0-bce4-97d6af576c46", "5ee38dea-4064-4505-8d65-b615c3d9085a", "User", "USER" },
                    { "ce5dd7fc-6168-4cb0-9bd0-5e995a1aac2f", "d38eebe5-a413-4cb2-a255-f285d6c263ab", "Moderator", "MODERATOR" },
                    { "ff879bcd-b0df-42da-a67f-f0facb6d69e6", "467f3bf6-5b07-43fc-8d07-e9dfa48cdfa9", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "24781e57-8f7d-42c4-a38b-cda5379d57b3", 0, "36989cd2-9678-4fe5-a9bb-8838d4012666", "user@catalogofgoods.com", true, null, null, false, null, "USER@CATALOGOFGOODS.COM", "USER@CATALOGOFGOODS.COM", "AQAAAAEAACcQAAAAEBWhaHOTwjivh0x4icqfavgKo8tVAOycaEzhLJhQlv8uW2AnV9IHooGMoXix6BGRwg==", null, false, "eabc549c-3c4e-49c0-a6aa-3dcbda87213a", false, "user@catalogofgoods.com" },
                    { "5157bd77-1614-4201-b6af-981befc9374f", 0, "c4b47c9a-5857-48bd-a1b3-4b189a0a28b2", "moderator@catalogofgoods.com", true, null, null, false, null, "MODERATOR@CATALOGOFGOODS.COM", "MODERATOR@CATALOGOFGOODS.COM", "AQAAAAEAACcQAAAAEG5bXFHmObaKW+kKOhx+R9p+njNzZiz8tGYV3mMUzdHISmCISBI+JyCU/9Rt9QMKXw==", null, false, "179eb089-41ca-4ca3-b573-47e2a38a34de", false, "moderator@catalogofgoods.com" },
                    { "cbbc2279-f86d-4b9d-91a6-5458152da87a", 0, "2eb13566-9c6d-4e6f-af3a-f62fc1a9d3e1", "admin@catalogofgoods.com", true, null, null, false, null, "ADMIN@CATALOGOFGOODS.COM", "ADMIN@CATALOGOFGOODS.COM", "AQAAAAEAACcQAAAAECHm4ojrVl9vmsMMMW21uzhThj7EfrvrBg5WTLYugpJmNbDHOLg0dSWJ/0iYZdkFaA==", null, false, "d14b096f-1b4d-4525-ae75-c1f364e476c9", false, "admin@catalogofgoods.com" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName" },
                values: new object[,]
                {
                    { 1, "HP" },
                    { 2, "LG" },
                    { 3, "CERSANIT" },
                    { 4, "ZiBi" },
                    { 5, "POPit" }
                });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "BuyerId", "BuyerName" },
                values: new object[,]
                {
                    { 1, "Денис Борисенко" },
                    { 2, "Максим Рибальчук" },
                    { 3, "Вячеслав Юдін" },
                    { 4, "Богдан Лаптєв" },
                    { 5, "Даніель Демчук" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Ноутбуки і компютери" },
                    { 2, "Побутова техніка" },
                    { 3, "Сантехніка та ремонт" },
                    { 4, "Дитячі товари" },
                    { 5, "Офіс,школа,книги" }
                });

            migrationBuilder.InsertData(
                table: "Goodes",
                columns: new[] { "GoodsId", "BrandId", "BuyerId", "CategoryId", "SellerId", "TypeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, 1 },
                    { 2, 2, 2, 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "SellerId", "SellerName" },
                values: new object[,]
                {
                    { 1, "Rozetka" },
                    { 2, "PartnerIT" },
                    { 3, "BestDealYear" },
                    { 4, "Free Sale" },
                    { 5, "Anita" },
                    { 6, "Zaino" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, "Ноутбуки" },
                    { 2, "Техніка для кухні" },
                    { 3, "Кераміка" },
                    { 4, "Іграшки" },
                    { 5, "Все для навчання" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2203cc7-160b-43b0-bce4-97d6af576c46", "24781e57-8f7d-42c4-a38b-cda5379d57b3" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a2203cc7-160b-43b0-bce4-97d6af576c46", "cbbc2279-f86d-4b9d-91a6-5458152da87a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff879bcd-b0df-42da-a67f-f0facb6d69e6", "cbbc2279-f86d-4b9d-91a6-5458152da87a" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BrandGoods_GoodesGoodsId",
                table: "BrandGoods",
                column: "GoodesGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyerGoods_GoodesGoodsId",
                table: "BuyerGoods",
                column: "GoodesGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryGoods_GoodesGoodsId",
                table: "CategoryGoods",
                column: "GoodesGoodsId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsSeller_SellersSellerId",
                table: "GoodsSeller",
                column: "SellersSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsType_TypesTypeId",
                table: "GoodsType",
                column: "TypesTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BrandGoods");

            migrationBuilder.DropTable(
                name: "BuyerGoods");

            migrationBuilder.DropTable(
                name: "CategoryGoods");

            migrationBuilder.DropTable(
                name: "GoodsSeller");

            migrationBuilder.DropTable(
                name: "GoodsType");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sellers");

            migrationBuilder.DropTable(
                name: "Goodes");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
