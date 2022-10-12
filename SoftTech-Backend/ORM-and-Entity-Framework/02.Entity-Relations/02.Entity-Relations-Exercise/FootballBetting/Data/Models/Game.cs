using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [Required]
        [ForeignKey("Team")]
        public int HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }

        [Required]
        [ForeignKey("Team")]
        public int AwayTeamId { get; set; }
        public Team? AwayTeam { get; set; }

        [Required]
        public int HomeTeamGoals { get; set; }

        [Required]
        public int AwayTeamGoals { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public double HomeTeamBetRate { get; set; }

        [Required]
        public double AwayTeamBetRate { get; set; }

        [Required]
        public double DrawBetRate { get; set; }

        [Required]
        public string Result { get; set; }

        public HashSet<PlayerStatistic>? PlayerStatistics { get; set; }
        public HashSet<Bet> Bets { get; set; }

        public Game()
        {
            PlayerStatistics = new HashSet<PlayerStatistic>();
            Bets = new HashSet<Bet>();
        }
    }
}