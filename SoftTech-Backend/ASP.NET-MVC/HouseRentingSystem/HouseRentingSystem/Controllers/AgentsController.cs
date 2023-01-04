using HouseRentingSystem.Data;
using HouseRentingSystem.Infrastructure;
using HouseRentingSystem.Models.Agents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class AgentsController : Controller
    {
        private readonly HouseRentingDbContext data;

        public AgentsController(HouseRentingDbContext data)
        {
            this.data = data;
        }

        [Authorize]
        public IActionResult Become()
        {
            if (this.data.Agents.Any(a => a.UserId == this.User.Id()))
            {
                return BadRequest();
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Become(BecomeAgentFormModel agent)
        {
            return RedirectToAction(nameof(HousesController.All), "Houses");
        }
    }
}
