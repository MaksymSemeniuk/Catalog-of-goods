using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class CatalogContext : IdentityDbContext<User>
    {
        public CatalogContext(DbContextOptions<CatalogContext> options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Seed();
            base.OnModelCreating(builder);
        }

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Typeg> Types { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Goods> Goodes { get; set; }
    }
}
