using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repository.Repositories;
using System.Diagnostics;

namespace GoodsControllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GoodsRepository _goodsRepository;
        private readonly CategoryRepository _categoryRepository;
        public HomeController(ILogger<HomeController> logger, GoodsRepository goodsRepository, CategoryRepository categoryRepository)
        {
            _logger = logger;
            _goodsRepository = goodsRepository;
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