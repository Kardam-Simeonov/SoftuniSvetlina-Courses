using System.ComponentModel.DataAnnotations;

namespace FootballBetting.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}