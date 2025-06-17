using HouseRentingSystem2._0.Attributes;
using HouseRentingSystem2._0.Core.Contracts.Agent;
using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.House;
using HouseRentingSystem2._0.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static HouseRentingSystem2._0.Core.Constants.MessageConstants;

namespace HouseRentingSystem2._0.Controllers
{

    public class HouseController : BaseController
    {
        private readonly IHouseService houseService;
        private readonly ILogger logger;
        private readonly IAgentService agentService;
        public HouseController(
            ILogger<HomeController> _logger,
            IHouseService _houseService,
            IAgentService _agentService)
        {
            logger = _logger;
            houseService = _houseService;
            agentService = _agentService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = new AllHousesQueryModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var model = new AllHousesQueryModel();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var model = new HouseDetailsViewModel();
            return View(model);
        }
        [HttpGet]
        [MustBeAnAgent]
        public async Task<IActionResult> Add()
        {
           
            var model = new HouseFormModel() 
            {
                Categories = await houseService.AllCategoriesAsync()
            };
            return View(model);
        }

        [HttpPost]
        [MustBeAnAgent]
        public async Task<IActionResult> Add(HouseFormModel model)
        {
            if(await houseService.CategoryExistsAsync(model.CategoryId) ==  false)
            {
                ModelState.AddModelError(nameof(model.CategoryId), InvalidCategoryId);
            }
            if (ModelState.IsValid == false)
            {

                model.Categories = await houseService.AllCategoriesAsync();
                return View(model);
            }

            int? agentId = await agentService.FindAgentByUserId(User.Id());

          
           int newHouseId=  await houseService.CreateAsync(model, agentId ?? 0);

            return RedirectToAction(nameof(Detail), new { id = newHouseId });

        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = new HouseFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit()
        {
            return RedirectToAction(nameof(Detail), new { id = 1 });
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new HouseDetailsViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(HouseDetailsViewModel house)
        {

            return RedirectToAction(nameof(All));

        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id)
        {

            return RedirectToAction(nameof(Mine));


        }
        [HttpPost]
        public async Task<IActionResult> Leave(int id)
        {

            return RedirectToAction(nameof(Mine));


        }
    }
}
