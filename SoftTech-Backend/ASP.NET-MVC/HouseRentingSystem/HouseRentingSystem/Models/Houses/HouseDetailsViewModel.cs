using HouseRentingSystem.Models.Agents;

namespace HouseRentingSystem.Models.Houses
{
    public class HouseDetailsViewModel : HouseViewModel
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public AgentViewModel Agent { get; set; }
    }
}
