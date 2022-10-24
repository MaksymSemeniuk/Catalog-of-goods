﻿// <auto-generated />
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
    [Migration("20221024034038_First")]
    partial class First
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

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Ноутбуки і компютери",
                            CategoryNumber = 0
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Побутова техніка",
                            CategoryNumber = 0
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Сантехніка та ремонт",
                            CategoryNumber = 0
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Дитячі товари",
                            CategoryNumber = 0
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Офіс,школа,книги",
                            CategoryNumber = 0
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
                            Id = "b124468c-ace0-4fba-b0e1-eb4cb3ea01da",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "772ea965-73f1-4a10-a929-6117b5f2f527",
                            Email = "admin@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@CATALOGOFGOODS.COM",
                            NormalizedUserName = "ADMIN@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAy3AnqElsFkOrQsKYegEAOdSYHinZbz2ufPAIc8B+9viQxIbf4pUoO4goIFxDzm1A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5f77338-1c33-4141-9b58-5bb4dc6902d7",
                            TwoFactorEnabled = false,
                            UserName = "admin@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "cf1d63ef-a8fe-4b99-abe3-c994ad56ca4a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "63a3dc35-4042-4844-8ada-a4f290035c8b",
                            Email = "moderator@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "MODERATOR@CATALOGOFGOODS.COM",
                            NormalizedUserName = "MODERATOR@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKa+QqVyrKKoxjBI+6NoGqLstMxonGuGxnyENZZYgw0hbj2wCKBV3+pCmkcIskNsxg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "700c56d2-d2e4-4356-8e1d-7f5e5d5cc415",
                            TwoFactorEnabled = false,
                            UserName = "moderator@catalogofgoods.com"
                        },
                        new
                        {
                            Id = "1bbdd272-3e55-4711-8004-8910f559b8dd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aba63f7d-1bb9-4ff0-a5bc-2690d4f75e05",
                            Email = "user@catalogofgoods.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@CATALOGOFGOODS.COM",
                            NormalizedUserName = "USER@CATALOGOFGOODS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBNzYsuBxjLbR2nshAp5eqG0IeNuWKIsfQZep/lRuOQvoDtTA0ZGvGF5ap1OdQb9Mg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2a10de25-bd9d-46eb-a28e-19365366a1a9",
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
                            Id = "8a570d8b-e1ac-4799-9527-73778738c84a",
                            ConcurrencyStamp = "4835e353-7ce1-4301-8c9c-f46752357145",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "e595f53d-ffe6-43e5-acee-bdfe8f6ded92",
                            ConcurrencyStamp = "a6004abc-c594-4cf0-932d-1153dae55ee2",
                            Name = "Moderator",
                            NormalizedName = "MODERATOR"
                        },
                        new
                        {
                            Id = "e45d2096-0be1-4ed1-b0b6-af6e089ca76b",
                            ConcurrencyStamp = "43ef5f45-22c9-48a0-a832-6587e765765f",
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
                            UserId = "b124468c-ace0-4fba-b0e1-eb4cb3ea01da",
                            RoleId = "8a570d8b-e1ac-4799-9527-73778738c84a"
                        },
                        new
                        {
                            UserId = "b124468c-ace0-4fba-b0e1-eb4cb3ea01da",
                            RoleId = "e45d2096-0be1-4ed1-b0b6-af6e089ca76b"
                        },
                        new
                        {
                            UserId = "1bbdd272-3e55-4711-8004-8910f559b8dd",
                            RoleId = "e45d2096-0be1-4ed1-b0b6-af6e089ca76b"
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