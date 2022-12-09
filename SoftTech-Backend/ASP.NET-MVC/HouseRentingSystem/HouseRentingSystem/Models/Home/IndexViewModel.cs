using HouseRentingSystem.Models.Houses;

namespace HouseRentingSystem.Models.Home
{
    public class IndexViewModel
    {
        public IEnumerable<HouseDetailsViewModel> Houses { get; set; } = new List<HouseDetailsViewModel>();
    }
}
