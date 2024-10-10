using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.DTOs;
using ManagementSystem.Models;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryCreateController : CategoryController
    {
        // Constructor to inject the category repository
        public CategoryCreateController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpPost("/api/v1/categories")]
        [SwaggerOperation(
            Summary = "Create a new category",
            Description = "Creates a new category record for a specified room and guest, ensuring all provided data is valid."
        )]
        public async Task<IActionResult?> Create(CategoryDTO categoryDto)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create a new category object from the provided categoryDto
            var newCategory = new Category(
                categoryDto.Name,
                categoryDto.Description
            );

            // Call the repository to save the new category
            await _categoryRepository.Create(newCategory);

            // Return the created category object as a response
            return Ok(newCategory);
        }
    }
}
