using System.ComponentModel;

namespace HouseRentingSystem.Models.Houses
{
    public class HouseViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }

        [DisplayName("ImageUrl")]
        public string ImageUrl { get; set; }

        [DisplayName("PricePerMonth")]
        public decimal PricePerMonth { get; set; }

        [DisplayName("Is Rented")]
        public bool IsRented { get; set; }
    }
}
