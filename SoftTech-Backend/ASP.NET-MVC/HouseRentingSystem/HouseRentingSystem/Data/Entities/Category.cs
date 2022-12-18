using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Data.DataConstants.Category;

namespace HouseRentingSystem.Data.Entities
{
    public class Category
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        public ICollection<House> Houses { get; init; } = new HashSet<House>();
    }
}
