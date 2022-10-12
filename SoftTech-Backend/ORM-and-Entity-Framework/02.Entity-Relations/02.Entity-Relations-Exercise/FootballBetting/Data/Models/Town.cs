using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Town
    {
        [Key]
        public int TownId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public Country? Country { get; set; }
    }
}