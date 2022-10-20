using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.BuyerDto
{
    public class BuyerReadDto
    {

        public int? BuyerId { get; set; }
        public string? BuyerName { get; set; }

        public ICollection<Goods>? Goodes { get; set; }

    }
}
