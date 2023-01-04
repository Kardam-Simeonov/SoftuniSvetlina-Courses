using System.Security.Claims;

namespace HouseRentingSystem.Infrastructure
{
    public static class ClaimsPrincipalExtrensions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        } 
    }
}
