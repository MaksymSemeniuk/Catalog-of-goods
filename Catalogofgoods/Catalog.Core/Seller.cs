using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string? SellerName { get; set; }
        public ICollection<Goods>? Goodes { get; set; }

    }
}
