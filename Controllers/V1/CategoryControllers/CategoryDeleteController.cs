using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryDeleteController : CategoryController
    {
        public CategoryDeleteController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpDelete("/api/v1/categories/{id} ")] 
        [SwaggerOperation(
            Summary = "Delete a category",
            Description = "Deletes a category record identified by the provided ID."
        )]
        public async Task<IActionResult> Delete(int id)
        {
            
            await _categoryRepository.Delete(id);
            return NoContent(); 
        }
    }
}