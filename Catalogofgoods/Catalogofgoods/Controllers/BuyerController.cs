using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Core;
using Catalog.Repository.Dto.BuyerDto;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class BuyerController : Controller
    {
        private readonly ILogger<BuyerController> _logger;
        private readonly BuyerRepository _buyerRepository;
        public BuyerController(ILogger<BuyerController> logger, BuyerRepository buyerRepository)
        {
            _logger = logger;
            _buyerRepository = buyerRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _buyerRepository.GetBuyerAsync());
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

