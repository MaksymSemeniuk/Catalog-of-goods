﻿// <auto-generated />
using System;
using Catalog.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Catalog.Core.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Ноутбуки і компютери"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Побутова техніка"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Сантехніка та ремонт"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Дитячі товари"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Офіс,школа,книги"
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
                            Id = "df21fa2f-50c5-49a2-9e8f-e97d0a1bc052",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "612500a2-9e60-45a9-aacb-4e3de99a6831",
                            Email = "admin@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@CATALOGOFGOODS.COM",
                            NormalizedUserName = "ADMIN@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKCYtSwGex85KwiJ+FSqD8FOgKQPk447r7PK6uOneZliRm1YbezhcJ4ViBCC5LPuQQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7e422887-a6ee-40b0-b01b-f3add62640b0",
                            TwoFactorEnabled = false,
                            UserName = "admin@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "dd1e4d44-013e-4fc8-b994-238abc59504f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b86726ee-a13f-4332-8fec-5a31fed4e6ea",
                            Email = "moderator@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@CATALOGOFGOODS.COM",
                            NormalizedUserName = "MODERATOR@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENrBJwYEGT67ukXTPUVWrAB8syBXlpeVScFeH35ACu+CaqoANKolzt233sGExSypNQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9920304c-420b-40cf-9a14-a0fb5b301d13",
                            TwoFactorEnabled = false,
                            UserName = "moderator@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "ac74fbe3-b830-4b65-a37f-0bb39ffc02b4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "99106cf5-42db-4c6f-b038-fb55cddd9ad7",
                            Email = "user@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@CATALOGOFGOODS.COM",
                            NormalizedUserName = "USER@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDUopYt1WaDenoLpGYP+EuuZN7/q65MDm8R6+qDj0ua7wTujxH6r8yL1McAsoIoC6A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "33a3b164-9e3b-4929-8f14-31d4f19927a2",
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
                            Id = "def9cdbb-4a18-452d-b9c6-65289e1bc125",
                            ConcurrencyStamp = "ed061d08-cba9-4cfa-9f56-4767ca433006",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "41d3f253-596f-4835-b007-1e2b971120c9",
                            ConcurrencyStamp = "2d8d6a9c-e0de-4ff7-9f17-4542efd18298",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "9f594d75-80eb-4207-ba6d-7a3cf7089011",
                            ConcurrencyStamp = "863bdd17-d3da-45bf-bbd1-9c43f0ce8544",
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
                            UserId = "df21fa2f-50c5-49a2-9e8f-e97d0a1bc052",
                            RoleId = "def9cdbb-4a18-452d-b9c6-65289e1bc125"
                        },
                        new
                        {
                            UserId = "df21fa2f-50c5-49a2-9e8f-e97d0a1bc052",
                            RoleId = "9f594d75-80eb-4207-ba6d-7a3cf7089011"
                        },
                        new
                        {
                            UserId = "ac74fbe3-b830-4b65-a37f-0bb39ffc02b4",
                            RoleId = "9f594d75-80eb-4207-ba6d-7a3cf7089011"
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