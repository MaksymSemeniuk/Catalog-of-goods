using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class Typeg
    {
        [Key]
        public int TypegId { get; set; }
        public string? TypegName { get; set; }
        public ICollection<Goods> Goodes { get; set; }

    }
}
