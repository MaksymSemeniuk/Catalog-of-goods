using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto.GoodsDto
{
    public class GoodsReadDto
    {
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
