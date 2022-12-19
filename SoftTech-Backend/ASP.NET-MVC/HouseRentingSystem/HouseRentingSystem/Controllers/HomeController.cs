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
            var allHouses = new IndexViewModel()
            {
                Houses = this.data.Houses
                    .Select(h => new HouseIndexViewModel()
                    {
                        Id = h.Id,
                        Title = h.Title,
                        ImageUrl = h.ImageUrl
                    })
            };

            return View(allHouses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}