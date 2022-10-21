using Catalog.Core;
using Catalog.Repository.Dto.GoodsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class GoodsRepository
    {
        private readonly CatalogContext _ctx;

        public GoodsRepository(CatalogContext ctx /*CabinetRepository vehicleModelRepository, ClassRepository bodyTypeRepository*/)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<GoodsReadDto>> GetGoodsAsync()
        {
            var goodsDto = _ctx.Goodes
                .Select(x => new GoodsReadDto
                {
                    Brand = x.Brand,
                    Buyer = x.Buyer,
                    Category = x.Category,
                    Seller = x.Seller,
                    Typeg = x.Typeg
                }).ToList();

            return goodsDto;
        }
    }
}
