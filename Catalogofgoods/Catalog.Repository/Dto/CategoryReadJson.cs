using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto
{
    public class CategoryReadJson
    {
        [JsonPropertyName("Category")]
        public int Category { get; set; }
    }
}
