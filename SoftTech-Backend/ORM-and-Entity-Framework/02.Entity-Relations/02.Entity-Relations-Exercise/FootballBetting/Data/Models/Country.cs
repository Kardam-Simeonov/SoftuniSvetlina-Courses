using System.ComponentModel.DataAnnotations;

namespace FootballBetting.Data.Models
{
    public class Country
    {
        [Required]
        public int CountryId { get; set; }

        [Required]
        public int Name { get; set; }
    }
}