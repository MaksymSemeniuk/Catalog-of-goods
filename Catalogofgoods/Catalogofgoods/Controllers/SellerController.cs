using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Core;
using Catalog.Repository.Dto.SellerDto;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class SellerController : Controller
    {
        private readonly ILogger<SellerController> _logger;
        private readonly SellerRepository _sellerRepository;
        public SellerController(ILogger<SellerController> logger, SellerRepository sellerRepository)
        {
            _logger = logger;
            _sellerRepository = sellerRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _sellerRepository.GetSellerAsync());
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

