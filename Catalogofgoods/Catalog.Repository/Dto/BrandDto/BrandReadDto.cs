using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.BrandDto
{
    public class BrandReadDto
    {

        public int BrandId { get; set; }
        public string? BrandName { get; set; }

        public ICollection<Goods> Goodes { get; set; }

    }
}
