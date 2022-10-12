using Microsoft.EntityFrameworkCore;
using One_to_One.Data.Models;
using OneToOne.Data.Models;

namespace One_to_One.Data
{
    public class StudentAddressContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public StudentAddressContext()
        {
            
        }
        
        public StudentAddressContext(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {
            
        }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.stringConfiguration);
            }
        }
        
    }
}
