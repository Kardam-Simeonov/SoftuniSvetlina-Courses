using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int PropNumber { get; set; }

        [Required]
        [ForeignKey("Team")]
        public int TeamId { get; set; }
        public Team? Team { get; set; }

        [Required]
        [ForeignKey("Position")]
        public int PositionId { get; set; }
        public Position? Position { get; set; }

        [Required]
        public bool IsInjured { get; set; }
    }

}
