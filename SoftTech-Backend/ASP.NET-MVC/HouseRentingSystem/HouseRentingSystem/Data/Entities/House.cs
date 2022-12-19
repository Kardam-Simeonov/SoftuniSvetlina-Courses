using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Data.DataConstants.House;

namespace HouseRentingSystem.Data.Entities
{
    public class House
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; }
        
        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }
        
        [Column(TypeName = "decimal(12,3)")]
        public decimal PricePerMonth { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; init; }
        public int AgentId { get; set; }
        public Agent Agent { get; init; }
        public string? RenterId { get; set; }
    }
}
