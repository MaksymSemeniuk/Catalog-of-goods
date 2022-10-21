using Catalog.Core;
using Catalog.Repository.Dto.BuyerDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class BuyerRepository
    {
        private readonly CatalogContext _ctx;
        public BuyerRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<BuyerReadDto>> GetBuyerAsync()
        {
            var buyerDto = _ctx.Buyers.
                Select(x => new BuyerReadDto
                {


                    BuyerId = x.BuyerId,
                    BuyerName = x.BuyerName,
                    Goodes = x.Goodes
                }).ToList();

            return buyerDto;
        }

    }
}
