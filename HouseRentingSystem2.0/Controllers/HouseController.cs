using HouseRentingSystem2._0.Core.Models.House;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2._0.Controllers
{
    [Authorize]
    public class HouseController : Controller
    {
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
        public IActionResult Add()
        {
            var model = new HouseDetailsViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(HouseFormModel model)
        {

            return RedirectToAction(nameof(Detail), new { id = 1 });

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
