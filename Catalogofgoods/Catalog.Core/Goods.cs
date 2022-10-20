using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Core
{
    public class Goods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsId { get; set; }

        public int BuyerId { get; set; }
        public virtual ICollection<Buyer>? Buyers { get; set; }

        public int CategoryId { get; set; }
        public virtual ICollection<Category>? Categories { get; set; }

        public int SellerId { get; set; }
        public virtual ICollection<Seller>? Sellers { get; set; }

        public int BrandId { get; set; }
        public virtual ICollection<Brand>? Brands { get; set; }

        public int TypeId { get; set; }
        public virtual ICollection<Type>? Types { get; set; }
    }
}
