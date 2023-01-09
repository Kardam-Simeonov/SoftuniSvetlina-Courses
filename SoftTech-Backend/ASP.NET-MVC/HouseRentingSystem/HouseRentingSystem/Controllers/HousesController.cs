using HouseRentingSystem.Data;
using HouseRentingSystem.Data.Entities;
using HouseRentingSystem.Infrastructure;
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
                    .Where(h => h.Agent.UserId == this.User.Id())
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
            if (!this.data.Agents.Any(a => a.UserId == this.User.Id()))
            {
                return RedirectToAction(nameof(AgentsController.Become), "Agents");
            }

            return View(new HouseFormModel
            {
                Categories = this.GetHouseCategories()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(HouseFormModel model)
        {
            if (!this.data.Agents.Any(a => a.UserId == this.User.Id()))
            {
                return RedirectToAction(nameof(AgentsController.Become), "Agents");
            }

            if (!this.data.Categories.Any(c => c.Id == model.CategoryId))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist.");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = this.GetHouseCategories();

                return View(model);
            }

            var agentId = this.data.Agents
                .FirstOrDefault(a => a.UserId == this.User.Id())
                .Id;
            
            var house = new House
            {
                Title = model.Title,
                Address = model.Address,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                PricePerMonth = model.PricePerMonth,
                CategoryId = model.CategoryId,
                AgentId = agentId
            };

            this.data.Houses.Add(house);
            this.data.SaveChanges();

            return RedirectToAction(nameof(Details), new { id = house.Id });
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var house = this.data.Houses.Find(id);

            if (house == null)
            {
                return BadRequest();
            }

            var agent = this.data.Agents.FirstOrDefault(a => a.Id == house.AgentId);

            if (agent == null || agent.UserId != this.User.Id())
            {
                return Unauthorized();
            }

            var houseModel = new HouseFormModel
            {
                Title = house.Title,
                Address = house.Address,
                Description = house.Description,
                ImageUrl = house.ImageUrl,
                PricePerMonth = house.PricePerMonth,
                CategoryId = house.CategoryId,
                Categories = this.GetHouseCategories()
            };

            return View(houseModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, HouseFormModel model)
        {
            var house = this.data.Houses.Find(id);
            if (house == null)
            {
                return this.View();
            }

            var agent = this.data.Agents.FirstOrDefault(a => a.Id == house.AgentId);

            if (agent == null || agent.UserId != this.User.Id())
            {
                return Unauthorized();
            }
            
            if (!this.data.Categories.Any(c => c.Id == model.CategoryId))
            {
                this.ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist.");
            }
            
            if (!ModelState.IsValid)
            {
                model.Categories = this.GetHouseCategories();

                return View(model);
            }

            house.Title = model.Title;
            house.Address = model.Address;
            house.Description = model.Description;
            house.ImageUrl = model.ImageUrl;
            house.PricePerMonth = model.PricePerMonth;
            house.CategoryId = model.CategoryId;

            this.data.SaveChanges();

            return RedirectToAction(nameof(Details), new { id = house.Id });
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var house = this.data.Houses.Find(id);

            if (house == null)
            {
                return BadRequest();
            }

            var agent = this.data.Agents.FirstOrDefault(a => a.Id == house.AgentId);

            if (agent == null || agent.UserId != this.User.Id())
            {
                return Unauthorized();
            }

            var model = new HouseDetailsViewModel()
            {
                Title = house.Title,
                Address = house.Address,
                ImageUrl = house.ImageUrl,
            };
            
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Delete(HouseDetailsViewModel model)
        {
            var house = this.data.Houses.Find(model.Id);

            if (house == null)
            {
                return BadRequest();
            }

            var agent = this.data.Agents.FirstOrDefault(a => a.Id == house.AgentId);
            
            if (agent == null || agent.UserId != this.User.Id())
            {
                return Unauthorized();
            }

            this.data.Houses.Remove(house);
            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
        }

        //[HttpPost]
        [Authorize]
        public IActionResult Rent(int id)
        {
            if (!this.data.Houses.Any(h => h.Id == id)) 
            {
                return BadRequest();
            }

            if (this.data.Agents.Any(a => a.UserId == this.User.Id()))
            {
                return Unauthorized();
            }

            var house = this.data.Houses.Find(id);

            if (house.RenterId != null)
            {
                return BadRequest();
            }

            house.RenterId = this.User.Id();
            this.data.SaveChanges();

            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        [Authorize]
        public IActionResult Leave(int id)
        {
            if (!this.data.Houses.Any(h => h.Id ==id && h.RenterId != null))
            {
                return BadRequest();
            }

            var house = this.data.Houses.Find(id);

            if (house.RenterId != this.User.Id())
            {
                return Unauthorized();
            }

            house.RenterId = null;
            this.data.SaveChanges();
            
            return RedirectToAction(nameof(Mine));
        }

        private IEnumerable<HouseCategoryViewModel> GetHouseCategories()
        {
            return this.data
                .Categories
                .Select(c => new HouseCategoryViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToList();
        }
    }
}
