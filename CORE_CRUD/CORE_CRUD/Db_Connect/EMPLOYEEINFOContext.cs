using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CORE_CRUD.Models;

#nullable disable

namespace CORE_CRUD.Db_Connect
{
    public partial class EMPLOYEEINFOContext : DbContext
    {
        public EMPLOYEEINFOContext()
        {
        }

        public EMPLOYEEINFOContext(DbContextOptions<EMPLOYEEINFOContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=CHETUIWK015\\SQLEXPRESS;Database=EMPLOYEEINFO;Trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("MOBILE");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<CORE_CRUD.Models.EMPModel> EMPModel { get; set; }
    }
}
