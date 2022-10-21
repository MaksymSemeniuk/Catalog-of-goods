using Catalog.Core;
using Catalog.Repository.Dto.BrandDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class BrandRepository
    {
        private readonly CatalogContext _ctx;
        public BrandRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<BrandReadDto>> GetBrandAsync()
        {
            var brandDto = _ctx.Brands.
                Select(x => new BrandReadDto
                {


                    BrandId = x.BrandId,
                    BrandName = x.BrandName,
                    Goodes = x.Goodes
                }).ToList();

            return brandDto;
        }

    }
}
