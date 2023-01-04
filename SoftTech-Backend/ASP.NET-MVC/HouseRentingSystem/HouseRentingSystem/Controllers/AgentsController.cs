using HouseRentingSystem.Data;
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
