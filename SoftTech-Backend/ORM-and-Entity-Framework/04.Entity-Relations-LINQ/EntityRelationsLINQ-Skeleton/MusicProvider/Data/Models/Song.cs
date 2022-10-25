using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string SongName { get; set; }

        [Required]
        [MaxLength(150)]
        public string SongArtist { get; set; }

        public virtual ICollection<Playlist> Playlists { get; set; }
    }
}
