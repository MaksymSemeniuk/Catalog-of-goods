using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Core;
using Catalog.Repository.Dto.BrandDto;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class BrandController : Controller
    {
        private readonly ILogger<BrandController> _logger;
        private readonly BrandRepository _brandRepository;
        public BrandController(ILogger<BrandController> logger, BrandRepository brandRepository)
        {
            _logger = logger;
            _brandRepository = brandRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _brandRepository.GetBrandAsync());
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

