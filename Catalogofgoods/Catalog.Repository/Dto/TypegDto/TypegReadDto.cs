using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.TypegDto
{
    public class TypegReadDto
    {

        public int TypegId { get; set; }
        public string? TypegName { get; set; }

        public ICollection<Goods> Goodes { get; set; }

    }
}
