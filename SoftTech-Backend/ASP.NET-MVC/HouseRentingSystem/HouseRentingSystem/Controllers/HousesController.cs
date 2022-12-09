using HouseRentingSystem.Models.Home;
using HouseRentingSystem.Models.Houses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    public class HousesController : Controller
    {
        public IActionResult All()
        {
            var allHouses = new AllHousesQueryModel()
            {
                Houses = Common.GetHouses()
            };

            return View(allHouses);
        }

        [Authorize]
        public IActionResult Mine()
        {
            return View(new AllHousesQueryModel());
        }

        public IActionResult Details(int id)
        {
            var house = Common.GetHouses().FirstOrDefault();

            return View(house);
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
