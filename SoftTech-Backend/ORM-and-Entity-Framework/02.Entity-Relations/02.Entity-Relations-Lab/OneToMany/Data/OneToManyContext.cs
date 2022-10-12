using Microsoft.EntityFrameworkCore;
using OneToMany.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_to_Many.Data
{
    public class OneToManyContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public OneToManyContext()
        {

        }

        public OneToManyContext(DbContextOptions optionsBuilder) : base()
        {

        }

        /*/
        protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Config.stringConfiguration);
            }
        }
        /*/
    }
}
