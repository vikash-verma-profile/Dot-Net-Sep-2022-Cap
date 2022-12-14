using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LinqQueries.Models
{
    public partial class TestDBContext : DbContext
    {
        public TestDBContext()
        {
        }

        public TestDBContext(DbContextOptions<TestDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblDepartment> TblDepartments { get; set; }
        public virtual DbSet<TblEmployee> TblEmployees { get; set; }
        public virtual DbSet<TblSample> TblSamples { get; set; }
        public virtual DbSet<TblSubDepartment> TblSubDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-CUO3FKB;Initial Catalog=TestDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tblDepartment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepartmentName).HasMaxLength(200);
            });

            modelBuilder.Entity<TblEmployee>(entity =>
            {
                entity.ToTable("tblEmployee");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeName).HasMaxLength(200);

                entity.Property(e => e.EmployeeSalary).HasColumnType("decimal(7, 2)");
            });

            modelBuilder.Entity<TblSample>(entity =>
            {
                entity.ToTable("tblSample");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Text).HasMaxLength(2000);
            });

            modelBuilder.Entity<TblSubDepartment>(entity =>
            {
                entity.ToTable("tblSubDepartment");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.SubDepartmentName).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
