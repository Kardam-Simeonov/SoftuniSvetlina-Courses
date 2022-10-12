using System.ComponentModel.DataAnnotations;

namespace FootballBetting.Data.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        public string Name { get; set; }

        public HashSet<Player>? Players { get; set; }

        public Position()
        {
            Players = new HashSet<Player>();
        }
    }
}