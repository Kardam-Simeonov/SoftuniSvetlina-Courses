using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class PlayerStatistic
    {
        [Required]
        [ForeignKey("Game")]
        public int GameId { get; set; }
        public Game? Game  { get; set; }

        [Required]
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public Player? Player { get; set; }

        [Required]
        public int ScoredGoals { get; set; }

        [Required]
        public int Assists { get; set; }

        [Required]
        public int MinutesPlayed { get; set; }
    }
}
