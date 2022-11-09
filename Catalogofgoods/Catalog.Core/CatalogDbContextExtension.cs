using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;

namespace Catalog.Core
{
    public static class CatalogDbContextExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();
            string MODERATOR_ROLE_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = ADMIN_ROLE_ID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                  new IdentityRole
                  {
                      Id = MODERATOR_ROLE_ID,
                      Name = "Moderator",
                      NormalizedName = "MODERATOR"
                  },
                new IdentityRole
                {
                    Id = USER_ROLE_ID,
                    Name = "User",
                    NormalizedName = "USER"
                });

            string ADMIN_ID = Guid.NewGuid().ToString();
            string USER_ID = Guid.NewGuid().ToString();
            string MODERATOR_ID = Guid.NewGuid().ToString();

            var admin = new User
            {
                Id = ADMIN_ID,
                UserName = "admin@catalogofgoods.com",
                Email = "admin@catalogofgoods.com",
                EmailConfirmed = true,
                NormalizedEmail = "admin@catalogofgoods.com".ToUpper(),
                NormalizedUserName = "admin@catalogofgoods.com".ToUpper()
            };

            var moderator = new User
            {
                Id = MODERATOR_ID,
                UserName = "moderator@catalogofgoods.com",
                Email = "moderator@catalogofgoods.com",
                EmailConfirmed = true,
                NormalizedEmail = "moderator@catalogofgoods.com".ToUpper(),
                NormalizedUserName = "moderator@catalogofgoods.com".ToUpper()
            };

            var user = new User
            {
                Id = USER_ID,
                UserName = "user@catalogofgoods.com",
                Email = "user@catalogofgoods.com",
                EmailConfirmed = true,
                NormalizedEmail = "user@catalogofgoods.com".ToUpper(),
                NormalizedUserName = "user@catalogofgoods.com".ToUpper()
            };

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            admin.PasswordHash = hasher.HashPassword(admin, "Admin$pass1");
            moderator.PasswordHash = hasher.HashPassword(moderator, "Moderator$pass1");
            user.PasswordHash = hasher.HashPassword(user, "User$pass1");

            builder.Entity<User>().HasData(admin, moderator, user);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MODERATOR_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = MODERATOR_ROLE_ID,
                    UserId = MODERATOR_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = MODERATOR_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID
                });

            builder.Entity<Typeg>().HasData(
               new Typeg
               {

                   TypegId = 1,
                   TypegName = "Ноутбуки",
                   // TimetableId=1

               },
               new Typeg
               {
                   TypegId = 2,
                   TypegName = "Техніка для кухні",
                   // TimetableId = 2

               },
               new Typeg
               {
                   TypegId = 3,
                   TypegName = "Кераміка",
                   // TimetableId = 3
               },
               new Typeg
               {
                   TypegId = 4,
                   TypegName = "Іграшки",
                   // TimetableId = 4
               },
               new Typeg
               {
                   TypegId = 5,
                   TypegName = "Все для навчання",
                   // TimetableId = 5
               });

            builder.Entity<Category>().HasData(
               new Category
               {
                   CategoryId = 1,
                   CategoryName = "Ноутбуки і компютери",
                   IconPath = @"\Images\165469_1519035578_0.png"
               },
               new Category
               {
                   CategoryId = 2,
                   CategoryName = "Побутова техніка",
                   IconPath = @"\Images\depositphotos_58139017-stock-photo-home-appliances-set-of-household.jpg"
               },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Сантехніка та ремонт",
                    IconPath = @"\Images\service-centre.jpg"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Дитячі товари",
                    IconPath = @"\Images\1577439474_kt128.jpg"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Офіс,школа,книги",
                    IconPath = @"\Images\KancelarskyPort_24_785x350.jpg"
                }


               );
            builder.Entity<Seller>().HasData(
               new Seller
               {
                   SellerId = 1,
                   SellerName = "Rozetka",
                   // TimetableId = 1
               },
                       new Seller
                       {
                           SellerId = 2,
                           SellerName = "PartnerIT",
                           // TimetableId = 2
                       },
                               new Seller
                               {
                                   SellerId = 3,
                                   SellerName = "BestDealYear",
                                   //TimetableId = 3
                               },
                                       new Seller
                                       {
                                           SellerId = 4,
                                           SellerName = "Free Sale",
                                           // TimetableId = 4
                                       },
                                               new Seller
                                               {
                                                   SellerId = 5,
                                                   SellerName = "Anita",
                                                   // TimetableId = 5
                                               },

                                               new Seller
                                               {
                                                   SellerId = 6,
                                                   SellerName = "Zaino",
                                                   // TimetableId = 5
                                               }


               );

            builder.Entity<Buyer>().HasData(
              new Buyer
              {
                  BuyerId = 1,
                  BuyerName = "Денис Борисенко",
                  // TimetableId = 1
              },
                 new Buyer
                 {
                     BuyerId = 2,
                     BuyerName = "Максим Рибальчук",
                     //TimetableId = 2
                 },
                   new Buyer
                   {
                       BuyerId = 3,
                       BuyerName = "Вячеслав Юдін",
                       // TimetableId = 3
                   },
                     new Buyer
                     {
                         BuyerId = 4,
                         BuyerName = "Богдан Лаптєв",
                         //TimetableId = 4
                     },
                       new Buyer
                       {
                           BuyerId = 5,
                           BuyerName = "Даніель Демчук",
                           // TimetableId = 5
                       }


              );


            builder.Entity<Brand>().HasData(
             new Brand
             {
                 BrandId = 1,
                 BrandName = "HP",
                 //TimetableId = 1



             },
               new Brand
               {
                   BrandId = 2,
                   BrandName = "LG",
                   // TimetableId = 2
               }, new Brand
               {
                   BrandId = 3,
                   BrandName = "CERSANIT",
                   // TimetableId = 3
               }, new Brand
               {
                   BrandId = 4,
                   BrandName = "ZiBi",
                   //TimetableId = 4
               }, new Brand
               {
                   BrandId = 5,
                   BrandName = "POPit",
                   // TimetableId = 5
               }
            );

            builder.Entity<Goods>().HasData(
             new Goods
             {
                 GoodsId = 1,
                 TypegId = 1,
                 CategoryId = 1,
                 BrandId = 1,
                 BuyerId = 1,
                 SellerId = 1
             },
             new Goods
             {
                 GoodsId = 2,
                 TypegId = 2,
                 CategoryId = 2,
                 BrandId = 2,
                 BuyerId = 2,
                 SellerId = 2
             },
             new Goods
             {
                 GoodsId = 3,
                 TypegId = 3,
                 CategoryId = 3,
                 BrandId = 3,
                 BuyerId = 3,
                 SellerId = 3
             },
             new Goods
             {
                 GoodsId = 4,
                 TypegId = 4,
                 CategoryId = 4,
                 BrandId = 4,
                 BuyerId = 4,
                 SellerId = 4
             },
             new Goods
             {
                 GoodsId = 5,
                 TypegId = 5,
                 CategoryId = 5,
                 BrandId = 5,
                 BuyerId = 5,
                 SellerId = 5
             }

             );
        }
    }
}

