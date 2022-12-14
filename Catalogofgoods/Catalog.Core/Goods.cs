using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Catalog.Core
{
    public class Goods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GoodsId { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        public int BuyerId { get; set; }
        public Buyer Buyer { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int SellerId { get; set; }
        public Seller Seller { get; set; }

        public int TypegId { get; set; }
        public Typeg Typeg { get; set; }
    }
}
