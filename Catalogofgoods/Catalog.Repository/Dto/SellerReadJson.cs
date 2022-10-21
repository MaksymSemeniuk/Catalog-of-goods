using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Catalog.Repository.Dto
{
    public class SellerReadJson
    {
        [JsonPropertyName("Seller")]
        public int Seller { get; set; }
    }
}
