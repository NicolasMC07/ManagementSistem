using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Seeders
{
    public class CategorySeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Electronics", Description = "Devices and gadgets" },
                new Category { Id = 2, Name = "Books", Description = "Various genres of books" },
                new Category { Id = 3, Name = "Clothing", Description = "Apparel and accessories" },
                new Category { Id = 4, Name = "Home & Kitchen", Description = "Home appliances and kitchenware" },
                new Category { Id = 5, Name = "Sports", Description = "Sports equipment and gear" }
            );
        }
    }
}