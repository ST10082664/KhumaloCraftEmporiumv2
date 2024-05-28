using KhumaloCraftEmporium.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace KhumaloCraftEmporium.DbController
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Additional configuration
            modelBuilder.Entity<User>().HasMany(u => u.Transactions).WithOne(t => t.User);
            modelBuilder.Entity<Product>().HasMany(p => p.Transactions).WithOne(t => t.Product);
        }
    }
}
