using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalog.Controllers
{
    public class GoodsController : Controller
    {

        private readonly ILogger<GoodsController> _logger;
        private readonly GoodsRepository _goodsRepository;
        public GoodsController(ILogger<GoodsController> logger, GoodsRepository goodsRepository)
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
