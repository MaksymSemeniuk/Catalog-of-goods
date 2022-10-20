using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.SellerDto
{
    public class SellerReadDto
    {

        public int? SellerId { get; set; }
        public string? SellerName { get; set; }

        public ICollection<Goods>? Goodes { get; set; }

    }
}
