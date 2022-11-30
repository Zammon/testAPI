using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TestAPI.Models;

namespace TestAPI.ApplicationDbContext
{
    public partial class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext()
        {
        }

        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Admin> Admins { get; set; } = null!;
        public virtual DbSet<Filter> Filters { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<ItemsFilter> ItemsFilters { get; set; } = null!;
        public virtual DbSet<Place> Places { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<Slide> Slides { get; set; } = null!;
        public virtual DbSet<Staff> Staffs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=119.59.96.90;Database=dropsideways_db;User ID=tong_admin;Password=7If&629zk; ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("tong_admin")
                .UseCollation("Thai_CI_AS");

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasOne(d => d.IdPostNavigation)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.IdPost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Images_Posts");
            });

            modelBuilder.Entity<ItemsFilter>(entity =>
            {
                entity.HasOne(d => d.IdFilterNavigation)
                    .WithMany(p => p.ItemsFilters)
                    .HasForeignKey(d => d.IdFilter)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemsFilter_Filters");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasOne(d => d.IdPlaceNavigation)
                    .WithOne(p => p.Place)
                    .HasForeignKey<Place>(d => d.IdPlace)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Places_Posts");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasOne(d => d.IdStaffNavigation)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.IdStaff)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Posts_Staffs");
            });

            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(e => e.IdStaff)
                    .HasName("PK_Staff");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
