using Catalog.Core;
using Catalog.Repository.Dto.SellerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class SellerRepository
    {
        private readonly CatalogContext _ctx;
        public SellerRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<SellerReadDto>> GetFuelTypesAsync()
        {
            var sellerDto = _ctx.Sellers.
                Select(x => new SellerReadDto
                {


                    SellerId = x.SellerId,
                    SellerName = x.SellerName,
                    Goodes = x.Goodes
                }).ToList();

            return sellerDto;
        }

    }
}
