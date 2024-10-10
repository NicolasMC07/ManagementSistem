using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Data
{

    public class AppDbContext : DbContext
    {
        //Tables


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }



        // Model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }

}