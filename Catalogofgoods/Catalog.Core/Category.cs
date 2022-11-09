using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Core
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryNumber { get; set; }
        public ICollection<Goods> Goodes { get; set; }
        public string IconPath { get; set; }
    }

}
