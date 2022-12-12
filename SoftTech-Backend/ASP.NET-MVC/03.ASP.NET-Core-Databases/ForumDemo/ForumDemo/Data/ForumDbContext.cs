using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace ForumDemo.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext(DbContextOptions<ForumDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostAnswer> PostAnswers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Post>()
            .HasMany(p => p.PostAnswers)
            .WithOne(r => r.Post);
        }
    }
}
