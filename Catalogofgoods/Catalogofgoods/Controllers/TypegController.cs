using Catalogofgoods.Models;
using Microsoft.AspNetCore.Mvc;
using Catalog.Core;
using Catalog.Repository.Dto.TypegDto;
using Catalog.Repository.Repositories;
using Catalogofgoods.Models;
using System.Diagnostics;

namespace Catalogofgoods.Controllers
{
    public class TypegController : Controller
    {
        private readonly ILogger<TypegController> _logger;
        private readonly TypegRepository _typegRepository;
        public TypegController(ILogger<TypegController> logger, TypegRepository typegRepository)
        {
            _logger = logger;
            _typegRepository = typegRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _typegRepository.GetTypegAsync());
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

