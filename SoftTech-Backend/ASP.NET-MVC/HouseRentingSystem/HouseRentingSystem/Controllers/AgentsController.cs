using HouseRentingSystem.Data;
using HouseRentingSystem.Data.Entities;
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
        public IActionResult Become(BecomeAgentFormModel model)
        {
            if (this.data.Agents.Any(a => a.UserId == this.User.Id()))
            {
                return BadRequest();
            }

            if (this.data.Agents.Any(a => a.PhoneNumber == model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), "Phone number already exists. Enter another one.");
            }

            if (this.data.Houses.Any(h => h.RenterId == this.User.Id()))
            {
                ModelState.AddModelError("Error", "You should have no rents to become an agent!");
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var agent = new Agent()
            {
                UserId = this.User.Id(),
                PhoneNumber = model.PhoneNumber
            };
            this.data.Agents.Add(agent);
            this.data.SaveChanges();

            return RedirectToAction(nameof(HousesController.All), "Houses");
        }
    }
}
