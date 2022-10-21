using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GoodsRepository _goodsRepository;
        public HomeController(ILogger<HomeController> logger, GoodsRepository goodsRepository)
        {
            _logger = logger;
            _goodsRepository = goodsRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _goodsRepository.GetGoodsAsync());
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