using Catalog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Catalog.Repository.Dto.CategoryDto
{
    public class CategoryReadDto
    {

        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        
        public ICollection<Goods>? Goodes { get; set; }

    }
}
