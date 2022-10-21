using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto
{
    public class TypegReadJson
    {
        [JsonPropertyName("Typeg")]
        public int Typeg { get; set; }
    }
}
