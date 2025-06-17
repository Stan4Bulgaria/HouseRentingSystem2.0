using HouseRentingSystem2._0.Core.Contracts.Agent;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using HouseRentingSystem2._0.Extensions;
using HouseRentingSystem2._0.Controllers;

namespace HouseRentingSystem2._0.Attributes
{
    public class MustBeAnAgentAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            IAgentService? agentService = context.HttpContext.RequestServices.GetService<IAgentService>();
            if (agentService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
            if (agentService != null && agentService.ExistsByIdAsync(context.HttpContext.User.Id()).Result == false)
            {
                context.Result =  new RedirectToActionResult(nameof(AgentController.Become), "Agent", null);
            }
        }
    }
}
