using Burgerking.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Burgerking.Data
{
    public class BurgerkingContext : DbContext
    {
        public BurgerkingContext(DbContextOptions<BurgerkingContext> options) : base(options)
        {
        }

        public DbSet<Burgers> Burgers { get; set; }
        public DbSet<Desserts> Desserts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Burgers>().ToTable("Burger").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Desserts>().ToTable("Dessert").Property(p => p.Prijs).HasColumnType("decimal(18,2)");
        }
    }
}