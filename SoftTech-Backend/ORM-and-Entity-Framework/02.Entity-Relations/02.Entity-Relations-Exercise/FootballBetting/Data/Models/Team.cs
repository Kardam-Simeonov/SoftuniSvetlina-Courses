using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballBetting.Data.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LogoUrl { get; set; }

        [Required]
        [StringLength(3)]
        public string Initials { get; set; }

        [Required]
        public decimal Budget { get; set; }

        [Required]
        [ForeignKey("Color")]
        public int PrimaryKitColorId { get; set; }
        public Color? PrimaryKitColor { get; set; }

        [Required]
        [ForeignKey("Color")]
        public int SecondaryKitColorId { get; set; }
        public Color? SecondaryKitColor { get; set; }

        [Required]
        [ForeignKey("Town")]
        public int TownId { get; set; }

        public Town? Town { get; set; }

    }
}
