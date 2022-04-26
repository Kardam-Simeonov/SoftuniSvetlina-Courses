using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VendingMachines.Models
{
    public partial class VendingMachinesContext : DbContext
    {
        public VendingMachinesContext()
        {
        }

        public VendingMachinesContext(DbContextOptions<VendingMachinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Machine> Machines { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=VendingMachines;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Machine>(entity =>
            {
                entity.Property(e => e.DateOfPlacement).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Logitude).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
