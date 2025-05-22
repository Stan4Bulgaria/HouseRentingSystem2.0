using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem2._0.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
