namespace HouseRentingSystem.Models.Houses
{
    public class AllHousesQueryModel 
    {
        public IEnumerable<HouseDetailsViewModel> Houses { get; set; } = new List<HouseDetailsViewModel>();
    }
}
