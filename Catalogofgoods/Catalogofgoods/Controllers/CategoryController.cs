using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Core;
using Catalog.Repository.Dto.CategoryDto;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly CategoryRepository _categoryRepository;
        public CategoryController(ILogger<CategoryController> logger, CategoryRepository categoryRepository)
        {
            _logger = logger;
            _categoryRepository = categoryRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoryRepository.GetCategoryAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

