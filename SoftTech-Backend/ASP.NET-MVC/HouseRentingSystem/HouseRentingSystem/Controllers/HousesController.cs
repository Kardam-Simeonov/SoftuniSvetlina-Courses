using HouseRentingSystem.Data;
using HouseRentingSystem.Models.Home;
using HouseRentingSystem.Models.Houses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem.Controllers
{
    public class HousesController : Controller
    {
        private readonly HouseRentingDbContext data;

        public HousesController(HouseRentingDbContext data)
        {
            this.data = data;
        }
        
        public IActionResult All()
        {
            var allHouses = new AllHousesQueryModel()
            {
                Houses = this.data.Houses
                    .Select(h => new HouseViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl
                    })
            };

            return View(allHouses);
        }

        [Authorize]
        public IActionResult Mine()
        {
            var allHouses = new AllHousesQueryModel()
            {
                Houses = this.data.Houses
                    .Where(h => h.Agent.UserId == this.User.FindFirst(ClaimTypes.NameIdentifier).Value)
                    .Select(h => new HouseViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl
                    })
            };

            return View(allHouses);
        }

        public IActionResult Details(int id)
        {
            var house = this.data.Houses.Find(id);

            if (house == null)
                return BadRequest();

            var houseModel = new HouseDetailsViewModel()
            {
                Title = house.Title,
                Address = house.Address,
                ImageUrl = house.ImageUrl,
            };

            return View(houseModel);
        }

        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(HouseFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            return View(new HouseFormModel());
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, HouseFormModel house)
        {
            return RedirectToAction("Details", new { id = "1" });
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            return View(new HouseDetailsViewModel());
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(HouseDetailsViewModel house)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
