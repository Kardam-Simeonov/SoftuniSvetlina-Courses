using Microsoft.EntityFrameworkCore;
using MusicHub.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data
{
    public class MusicHubContext : DbContext
    {
        public MusicHubContext()
        {
        }

        public MusicHubContext(DbContextOptions<MusicHubContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Performer> Performers { get; set; }
        public virtual DbSet<Producer> Producers { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Writer> Writers { get; set; }
        public virtual DbSet<SongPerformer> SongPerformers { get; set; }
    }
}
