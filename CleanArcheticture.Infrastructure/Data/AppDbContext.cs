using CleanArcheticture.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcheticture.Infrastructure
    {
    public class AppDbContext : DbContext
        {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
            {
            }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieTypes> MovieTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            base.OnModelCreating(modelBuilder);

            // Configure Movie
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies"); 
                entity.HasKey(m => m.Id); 
                entity.Property(m => m.Name)
                      .IsRequired()
                      .HasMaxLength(100); 
                entity.Property(m => m.Cost)
                      .IsRequired();
            });

            // Configure MovieTypes
            modelBuilder.Entity<MovieTypes>(entity =>
            {
                entity.ToTable("MovieTypes");
                entity.HasKey(mt => mt.Id);
                entity.Property(mt => mt.Name)
                      .IsRequired()
                      .HasMaxLength(50);
            });
            }
        }
    }
