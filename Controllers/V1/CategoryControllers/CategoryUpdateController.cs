using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.DTOs;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryUpdateController : CategoryController
    {
         // Constructor to inject the category repository
        public CategoryUpdateController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpPut("/api/v1/categories/{id} ")] // Specifies the HTTP PUT method for updating a category by ID
        [SwaggerOperation(
            Summary = "Update category information",
            Description = "Updates the details of an existing category identified by the provided ID."
        )]
        public async Task<IActionResult> Update(int id, CategoryDTO guestDto)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Retrieve the existing category by ID
            var existCategory = await _categoryRepository.GetById(id);
            if (existCategory == null)
            {
                return NotFound(); // Return NotFound if the category does not exist
            }

            // Update category properties with the new data from guestDto
            existCategory.Name = guestDto.Name;
            existCategory.Description = guestDto.Description;
            // Call the repository to update the category record
            await _categoryRepository.Update(existCategory);

            return NoContent(); // Return NoContent to indicate successful update
        }
    }
}