using HouseRentingSystem2._0.Attributes;
using static  HouseRentingSystem2._0.Core.Constants.MessageConstants;
using HouseRentingSystem2._0.Core.Contracts.Agent;
using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.Agent;
using HouseRentingSystem2._0.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem2._0.Controllers
{
   
    public class AgentController : BaseController
    {
        private readonly ILogger<AgentController> logger;
        private readonly IConfiguration configuration;
        private readonly IAgentService agentService;
        public AgentController(

            ILogger<AgentController> _logger,
            IConfiguration _configuration,
            IAgentService _agentService

            )
        {
            logger = _logger;
            configuration = _configuration;
            agentService = _agentService;
        }
        [HttpGet]
        [NotAnAgentAttribute]
        public IActionResult Become()
        {
            var model = new BecomeAgentFormModel();
            return View(model);
        }
        [HttpPost]
        [NotAnAgentAttribute]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {
            if(await agentService.UserWithPhoneNumberExistsAsync(model.PhoneNumber) == true)
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneNumberAlReadyExists);
            }
            if(await agentService.UserHasRentsAsync(User.Id()))
            {
                ModelState.AddModelError("Error", UserIsRenting);
            }
            if(ModelState.IsValid == false)
            {
                return View(model);
            }
            await agentService.CreateAsync(User.Id(), model.PhoneNumber);

            return RedirectToAction(nameof(HouseController.All), "House");
        }


    }
}
