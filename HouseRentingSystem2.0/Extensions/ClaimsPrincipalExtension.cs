using System.Security.Claims;

namespace HouseRentingSystem2._0.Extensions
{
    public static class ClaimsPrincipalExtension
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);  
        }
    }
}
