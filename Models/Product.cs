using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{   [Table("product")]
    public class Product
    {    
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("category_id")]
        public int CategoryId { get; set; }

        [ForeignKey("EmployeeId")]
        public Category? Category { get; set; }

        public Product(string name, string description, double price, int categoryId)
        {
            Name = name.ToLower().Trim(); Description = description.ToLower().Trim(); Price = price; CategoryId = categoryId;
        }

        public Product()
        {
        }
    }
}