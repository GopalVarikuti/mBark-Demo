using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Demo.Service.Models
{
    public partial class CarnivalDemoContext : DbContext
    {
        public CarnivalDemoContext()
        {
        }

        public CarnivalDemoContext(DbContextOptions<CarnivalDemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Login> Login { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=VGPCDOTNET-03\\SQLEXPRESS;Database=CarnivalDemo;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Authors>(entity =>
            {
                entity.HasKey(e => e.AgentId);

                entity.ToTable("Authors", "dbo");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agentId")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceId).HasColumnName("deviceId");

                entity.Property(e => e.LocationCode).HasColumnName("locationCode");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.UtcDatetime).HasColumnName("utcDatetime");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.AgentId)
                    .HasName("PK__Login__350C70C2357B6A98");

                entity.ToTable("Login", "dbo");

                entity.Property(e => e.AgentId)
                    .HasColumnName("agentId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceId)
                    .HasColumnName("deviceId")
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("locationCode")
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UtcDatetime)
                    .HasColumnName("utcDatetime")
                    .IsUnicode(false);
            });
        }
    }
}
