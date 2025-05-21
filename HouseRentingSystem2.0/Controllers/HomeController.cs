using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.Home;
using HouseRentingSystem2._0.Models;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IHouseService houseService;

        public HomeController(
            ILogger<HomeController> logger,
            IHouseService _houseService)
        {
            _logger = logger;
            houseService = _houseService;

        }

        public async Task<IActionResult> Index()
        {
            var model = await houseService.LastThreeHouses();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
