using HouseRentingSystem.Data;
using HouseRentingSystem.Models;
using HouseRentingSystem.Models.Home;
using HouseRentingSystem.Models.Houses;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly HouseRentingDbContext data;

        public HomeController(HouseRentingDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            var totalHouses = this.data.Houses.Count();

            var totalRents = this.data.Houses.Where(h => h.RenterId != null).Count();

            var houses = this.data.Houses.OrderByDescending(h => h.Id)
                .Select(h => new HouseIndexViewModel
                {
                    Id = h.Id,
                    Title = h.Title,
                    ImageUrl = h.ImageUrl
                })
                .Take(3)
                .ToList();

            return View(new IndexViewModel
            {
                TotalHouses = totalHouses,
                TotalRents = totalRents,
                Houses = houses
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }
            
            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}