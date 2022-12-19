using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.House;

namespace HouseRentingSystem.Models.Houses
{
    public class HouseFormModel
    {
        [Required]
        [StringLength(TitleMaxLength, MinimumLength = TitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string Address { get; set; }

        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Range(0.00, MaxPricePerMonth, ErrorMessage = "Price Per Month must be a positive number and less than {2} leva")]
        public decimal PricePerMonth { get; set; }

        public int CategoryId { get; init; }
        public IEnumerable<HouseCategoryViewModel> Categories { get; set; }
            = new List<HouseCategoryViewModel>();
    }
}
