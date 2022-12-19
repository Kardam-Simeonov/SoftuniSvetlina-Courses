namespace HouseRentingSystem.Models.Houses
{
    public class AllHousesQueryModel 
    {
        public IEnumerable<HouseViewModel> Houses { get; set; } = new List<HouseViewModel>();
    }
}
