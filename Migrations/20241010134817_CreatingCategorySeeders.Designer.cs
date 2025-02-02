﻿// <auto-generated />
using ManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241010134817_CreatingCategorySeeders")]
    partial class CreatingCategorySeeders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ManagementSystem.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Devices and gadgets",
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Various genres of books",
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Apparel and accessories",
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Home appliances and kitchenware",
                            Name = "Home & Kitchen"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Sports equipment and gear",
                            Name = "Sports"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
