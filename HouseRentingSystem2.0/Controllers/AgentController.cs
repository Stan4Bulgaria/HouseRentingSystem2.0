using HouseRentingSystem2._0.Core.Contracts.Agent;
using HouseRentingSystem2._0.Core.Contracts.House;
using HouseRentingSystem2._0.Core.Models.Agent;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public async  Task<IActionResult> Become()
        {
            string userId = User.Identity.Name;
            
            var model = new BecomeAgentFormModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HouseController.All), "Houses");
        }


    }
}
