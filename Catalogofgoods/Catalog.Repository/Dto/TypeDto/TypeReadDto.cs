using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.TypeDto
{
    public class TypeReadDto
    {

        public int? TypeId { get; set; }
        public string? TypeName { get; set; }

        public ICollection<Goods>? Goodes { get; set; }

    }
}
