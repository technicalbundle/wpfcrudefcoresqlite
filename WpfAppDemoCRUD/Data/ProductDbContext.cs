using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppDemoCRUD.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(GetProducts());
            base.OnModelCreating(modelBuilder);
        }

        private Product[] GetProducts()
        {
            return new Product[]
            {
                new Product { Id = 1, Name = "Tshirt", Description = "Red", Price = 19.99, Unit =5},
                new Product { Id = 2, Name = "Tshirt", Description = "Blue Color", Price = 10.99, Unit =50},
                new Product { Id = 3, Name = "Shirt", Description = "Formal Shirt", Price = 10.99, Unit =25},
                new Product { Id = 4, Name = "Socks", Description = "Yellow ", Price = 2, Unit =500},
            };
        }
    }
}
