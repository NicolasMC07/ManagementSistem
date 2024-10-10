using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementSystem.DTOs
{
    public class CategoryDTO
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
    }
}