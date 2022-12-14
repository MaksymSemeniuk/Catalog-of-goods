// <auto-generated />
using System;
using Catalog.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Core.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20221110205922_TWW")]
    partial class TWW
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Catalog.Core.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "HP"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "LG"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "CERSANIT"
                        },
                        new
                        {
                            BrandId = 4,
                            BrandName = "ZiBi"
                        },
                        new
                        {
                            BrandId = 5,
                            BrandName = "POPit"
                        });
                });

            modelBuilder.Entity("Catalog.Core.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyerId"), 1L, 1);

                    b.Property<string>("BuyerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BuyerId");

                    b.ToTable("Buyers");

                    b.HasData(
                        new
                        {
                            BuyerId = 1,
                            BuyerName = "Денис Борисенко"
                        },
                        new
                        {
                            BuyerId = 2,
                            BuyerName = "Максим Рибальчук"
                        },
                        new
                        {
                            BuyerId = 3,
                            BuyerName = "Вячеслав Юдін"
                        },
                        new
                        {
                            BuyerId = 4,
                            BuyerName = "Богдан Лаптєв"
                        },
                        new
                        {
                            BuyerId = 5,
                            BuyerName = "Даніель Демчук"
                        });
                });

            modelBuilder.Entity("Catalog.Core.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryNumber")
                        .HasColumnType("int");

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Ноутбуки і компютери",
                            CategoryNumber = 0,
                            IconPath = "\\Images\\165469_1519035578_0.png"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Побутова техніка",
                            CategoryNumber = 0,
                            IconPath = "\\Images\\depositphotos_58139017-stock-photo-home-appliances-set-of-household.jpg"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Сантехніка та ремонт",
                            CategoryNumber = 0,
                            IconPath = "\\Images\\service-centre.jpg"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Дитячі товари",
                            CategoryNumber = 0,
                            IconPath = "\\Images\\1577439474_kt128.jpg"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Офіс,школа,книги",
                            CategoryNumber = 0,
                            IconPath = "\\Images\\KancelarskyPort_24_785x350.jpg"
                        });
                });

            modelBuilder.Entity("Catalog.Core.Goods", b =>
                {
                    b.Property<int>("GoodsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GoodsId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("BuyerId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("TypegId")
                        .HasColumnType("int");

                    b.HasKey("GoodsId");

                    b.HasIndex("BrandId");

                    b.HasIndex("BuyerId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SellerId");

                    b.HasIndex("TypegId");

                    b.ToTable("Goodes");

                    b.HasData(
                        new
                        {
                            GoodsId = 1,
                            BrandId = 1,
                            BuyerId = 1,
                            CategoryId = 1,
                            SellerId = 1,
                            TypegId = 1
                        },
                        new
                        {
                            GoodsId = 2,
                            BrandId = 2,
                            BuyerId = 2,
                            CategoryId = 2,
                            SellerId = 2,
                            TypegId = 2
                        },
                        new
                        {
                            GoodsId = 3,
                            BrandId = 3,
                            BuyerId = 3,
                            CategoryId = 3,
                            SellerId = 3,
                            TypegId = 3
                        },
                        new
                        {
                            GoodsId = 4,
                            BrandId = 4,
                            BuyerId = 4,
                            CategoryId = 4,
                            SellerId = 4,
                            TypegId = 4
                        },
                        new
                        {
                            GoodsId = 5,
                            BrandId = 5,
                            BuyerId = 5,
                            CategoryId = 5,
                            SellerId = 5,
                            TypegId = 5
                        });
                });

            modelBuilder.Entity("Catalog.Core.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SellerId"), 1L, 1);

                    b.Property<string>("SellerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = 1,
                            SellerName = "Rozetka"
                        },
                        new
                        {
                            SellerId = 2,
                            SellerName = "PartnerIT"
                        },
                        new
                        {
                            SellerId = 3,
                            SellerName = "BestDealYear"
                        },
                        new
                        {
                            SellerId = 4,
                            SellerName = "Free Sale"
                        },
                        new
                        {
                            SellerId = 5,
                            SellerName = "Anita"
                        },
                        new
                        {
                            SellerId = 6,
                            SellerName = "Zaino"
                        });
                });

            modelBuilder.Entity("Catalog.Core.Typeg", b =>
                {
                    b.Property<int>("TypegId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypegId"), 1L, 1);

                    b.Property<string>("TypegName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypegId");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            TypegId = 1,
                            TypegName = "Ноутбуки"
                        },
                        new
                        {
                            TypegId = 2,
                            TypegName = "Техніка для кухні"
                        },
                        new
                        {
                            TypegId = 3,
                            TypegName = "Кераміка"
                        },
                        new
                        {
                            TypegId = 4,
                            TypegName = "Іграшки"
                        },
                        new
                        {
                            TypegId = 5,
                            TypegName = "Все для навчання"
                        });
                });

            modelBuilder.Entity("Catalog.Core.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "6d961fe7-1b25-46b8-9b66-0b8cf246a479",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1df1872b-011d-4937-abf4-71ed8361dcc7",
                            Email = "admin@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@CATALOGOFGOODS.COM",
                            NormalizedUserName = "ADMIN@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJBK+5KTqbIgIS3yTuu0+Rw6F0z/4uVxasLlteInmFVcIKaHWQ25InLc3W5cyG2+nA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4a227c6e-892f-47c8-a01c-b379c7c22765",
                            TwoFactorEnabled = false,
                            UserName = "admin@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "aa173607-64d0-46aa-80d6-3a86627e8890",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "36df6ab2-4d34-49d8-b3c9-25c3131c33a7",
                            Email = "moderator@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@CATALOGOFGOODS.COM",
                            NormalizedUserName = "MODERATOR@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELTeMk0U47Nf6TIcjtYmXTXhAnBJRoRJfcvjzz5fadV+/DmE4wUqwP1brCI/K3xtPg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29b68299-455f-4a63-bb4d-bff2c97eda91",
                            TwoFactorEnabled = false,
                            UserName = "moderator@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "d9215f9e-82d9-45ec-9386-f6718c42ca26",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6999abf0-7265-4eeb-9178-7bc4859cc23a",
                            Email = "user@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@CATALOGOFGOODS.COM",
                            NormalizedUserName = "USER@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJKJ9q8KaQO2G2SY74tpaMSLmgHq5WRs4rbksRPGXoB7TVLB5kRd5nsNO7RTw03HqA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "55df1a4d-2fd0-4e73-859a-0d1325fed574",
                            TwoFactorEnabled = false,
                            UserName = "user@catalogofgoods.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a1006b9a-1e89-417e-bf7a-18be531fda03",
                            ConcurrencyStamp = "94f824e5-7532-4bde-9ca3-3553995354e6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b28d53fa-58ce-4e48-8538-f79da9cee39c",
                            ConcurrencyStamp = "0200c53c-6ef4-43a7-aea4-23bcecb78040",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "d0386894-c566-4be6-9d80-2050d8c6a50d",
                            ConcurrencyStamp = "37c929ea-c719-4dec-9b76-99e1970c9f00",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6d961fe7-1b25-46b8-9b66-0b8cf246a479",
                            RoleId = "a1006b9a-1e89-417e-bf7a-18be531fda03"
                        },
                        new
                        {
                            UserId = "6d961fe7-1b25-46b8-9b66-0b8cf246a479",
                            RoleId = "b28d53fa-58ce-4e48-8538-f79da9cee39c"
                        },
                        new
                        {
                            UserId = "aa173607-64d0-46aa-80d6-3a86627e8890",
                            RoleId = "b28d53fa-58ce-4e48-8538-f79da9cee39c"
                        },
                        new
                        {
                            UserId = "aa173607-64d0-46aa-80d6-3a86627e8890",
                            RoleId = "d0386894-c566-4be6-9d80-2050d8c6a50d"
                        },
                        new
                        {
                            UserId = "6d961fe7-1b25-46b8-9b66-0b8cf246a479",
                            RoleId = "d0386894-c566-4be6-9d80-2050d8c6a50d"
                        },
                        new
                        {
                            UserId = "d9215f9e-82d9-45ec-9386-f6718c42ca26",
                            RoleId = "d0386894-c566-4be6-9d80-2050d8c6a50d"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Catalog.Core.Goods", b =>
                {
                    b.HasOne("Catalog.Core.Brand", "Brand")
                        .WithMany("Goodes")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Core.Buyer", "Buyer")
                        .WithMany("Goodes")
                        .HasForeignKey("BuyerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Core.Category", "Category")
                        .WithMany("Goodes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Core.Seller", "Seller")
                        .WithMany("Goodes")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Core.Typeg", "Typeg")
                        .WithMany("Goodes")
                        .HasForeignKey("TypegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Buyer");

                    b.Navigation("Category");

                    b.Navigation("Seller");

                    b.Navigation("Typeg");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Catalog.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Catalog.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Catalog.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Catalog.Core.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Catalog.Core.Brand", b =>
                {
                    b.Navigation("Goodes");
                });

            modelBuilder.Entity("Catalog.Core.Buyer", b =>
                {
                    b.Navigation("Goodes");
                });

            modelBuilder.Entity("Catalog.Core.Category", b =>
                {
                    b.Navigation("Goodes");
                });

            modelBuilder.Entity("Catalog.Core.Seller", b =>
                {
                    b.Navigation("Goodes");
                });

            modelBuilder.Entity("Catalog.Core.Typeg", b =>
                {
                    b.Navigation("Goodes");
                });
#pragma warning restore 612, 618
        }
    }
}
