using Codecool.CodecoolShop.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Codecool.CodecoolShop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ronal = new Supplier { Id = 1, Name = "Ronal", Description = "Producent of rims" };
            var rims = new ProductCategory { Id = 1, Name = "Rims", Department = "Rims", Description = "Wheel rims are something necessary in your car to make it look impressive and be safe." };
            var tires = new ProductCategory { Id = 2, Name = "Tires", Department = "Tires", Description = "Tires are ones of the most important part of your car for safety and efficiency reasons." };
            var trunks = new ProductCategory { Id = 3, Name = "Trunks", Department = "Trunks", Description = "Things to carry your luggage." };
            var accesories = new ProductCategory { Id = 4, Name = "Accesories", Department = "Accesories", Description = "Various car accessories." };
            
            modelBuilder.Entity<Supplier>().HasData(ronal);
            modelBuilder.Entity<ProductCategory>().HasData(rims);
            modelBuilder.Entity<ProductCategory>().HasData(tires);
            modelBuilder.Entity<ProductCategory>().HasData(trunks);
            modelBuilder.Entity<ProductCategory>().HasData(accesories);
            modelBuilder.Entity<Product>().HasData(new Product { Id = 1, Name = "Alutec Grip Polar", DefaultPrice = 399.0m, Currency = "USD", Description = "Fantastic price for a high quality product. Great and modern design that will make your car look amazing.", ProductCategoryId = 1, SupplierId = 1 });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            

            base.OnConfiguring(optionsBuilder);
        }
    }
}
