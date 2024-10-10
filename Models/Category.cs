using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.Models
{   
    [Table("categories")]
    public class Category
    {   
        [Column("id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        public Category(int id, string name, string description)
        {
            Name = name; 
            Description = description;
        }

        public Category()
        {
            
        }
    }
}