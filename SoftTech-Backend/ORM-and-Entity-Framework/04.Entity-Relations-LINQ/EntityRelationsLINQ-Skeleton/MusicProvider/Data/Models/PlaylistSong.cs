using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MusicProvider.Data.Models
{
    public class PlaylistSong
    {
        [Key]
        public int PlaylistId { get; set; }

        public virtual Playlist Playlist { get; set; }

        [Key]
        public int SongId { get; set; }

        public virtual Song Song { get; set; }
    }
}
