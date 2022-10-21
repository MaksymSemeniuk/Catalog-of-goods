using Catalog.Core;
using Catalog.Repository.Dto.CategoryDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Repository.Repositories
{
    public class CategoryRepository
    {
        private readonly CatalogContext _ctx;
        public CategoryRepository(CatalogContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<CategoryReadDto>> GetCategoryAsync()
        {
            var categoryDto = _ctx.Categories.
                Select(x => new CategoryReadDto
                {


                    CategoryId = x.CategoryId,
                    CategoryName = x.CategoryName,
                    Goodes = x.Goodes
                }).ToList();

            return categoryDto;
        }

    }
}
