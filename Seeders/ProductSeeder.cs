using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Seeders
{
    public class ProductSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99, CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Description = "High-performance laptop", Price = 1299.99, CategoryId = 1 },
            new Product { Id = 3, Name = "Fiction Book", Description = "Best-selling fiction novel", Price = 15.99, CategoryId = 2 },
            new Product { Id = 4, Name = "T-Shirt", Description = "Comfortable cotton t-shirt", Price = 19.99, CategoryId = 3 },
            new Product { Id = 5, Name = "Yoga Mat", Description = "Non-slip yoga mat", Price = 25.99, CategoryId = 5 }
        );
    }
    }
}