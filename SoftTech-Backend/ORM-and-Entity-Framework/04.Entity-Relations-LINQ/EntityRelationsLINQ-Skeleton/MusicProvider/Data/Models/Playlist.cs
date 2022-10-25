using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class Playlist
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [ForeignKey("User")]
        public int? UserId { get; set; }

        public virtual User? User { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
