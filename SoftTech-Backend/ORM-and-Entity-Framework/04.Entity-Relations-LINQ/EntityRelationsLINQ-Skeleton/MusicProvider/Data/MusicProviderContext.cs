using Microsoft.EntityFrameworkCore;

namespace MusicProvider.Data
{
    public class MusicProviderContext : DbContext
    {
        public MusicProviderContext()
        {
        }
        public MusicProviderContext(DbContextOptions options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        }
    }
}
