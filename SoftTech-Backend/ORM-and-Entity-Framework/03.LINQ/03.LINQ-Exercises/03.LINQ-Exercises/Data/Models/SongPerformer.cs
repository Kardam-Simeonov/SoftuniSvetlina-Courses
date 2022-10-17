using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models
{
    public class SongPerformer
    {
        [Key, Column(Order = 0)]
        public int SongId { get; set; }

        [Required]
        public virtual Song Song { get; set; }

        [Key, Column(Order = 3)]
        public int PerformerId { get; set; }

        [Required]
        public Performer Performer { get; set; }
    }
}