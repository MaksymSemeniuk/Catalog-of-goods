using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class Type
    {
        [Key]
        public int TypeId { get; set; }
        public string? TypeName { get; set; }
        public ICollection<Goods>? Goodes { get; set; }

    }
}
