using Catalog.Core;
using Catalog.Repository.Dto.TypeDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class TypeRepository
    {
        private readonly CatalogContext _ctx;
        public TypeRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<TypeReadDto>> GetFuelTypesAsync()
        {
            var typeDto = _ctx.Types.
                Select(x => new TypeReadDto
                {


                    TypeId = x.TypeId,
                    TypeName = x.TypeName,
                    Goodes = x.Goodes
                }).ToList();

            return typeDto;
        }

    }
}
