using Catalog.Core;
using Catalog.Repository.Dto.TypegDto;

namespace Catalog.Repository.Repositories
{
    public class TypegRepository
    {
        private readonly CatalogContext _ctx;
        public TypegRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<TypegReadDto>> GetTypegAsync()
        {
            var typegDto = _ctx.Types.
                Select(x => new TypegReadDto
                {


                    TypegId = x.TypegId,
                    TypegName = x.TypegName,
                    Goodes = x.Goodes
                }).ToList();

            return typegDto;
        }

    }
}
