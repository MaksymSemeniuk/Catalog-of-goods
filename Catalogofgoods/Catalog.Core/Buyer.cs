using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        public string? BuyerName { get; set; }
        public ICollection<Goods> Goodes { get; set; }

    }
}
