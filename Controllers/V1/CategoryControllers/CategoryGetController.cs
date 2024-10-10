using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Models;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.CategoryControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryGetController : CategoryController
    {
        
        public CategoryGetController(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
        }

        [HttpGet("/api/v1/categories/{id}")] 
        [SwaggerOperation(
            Summary = "Get category by ID",
            Description = "Retrieves a category record based on the provided category ID."
        )]
        public async Task<ActionResult<Category>> GetById(int id)
        {

            var category = await _categoryRepository.GetById(id);
            if (category == null)
            {
                return NotFound(); 
            }
            return category; 
        }

        [HttpGet("/api/v1/categories")] 
        [SwaggerOperation(
            Summary = "Get all categories",
            Description = "Retrieves a list of all registered categories."
        )]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            
            var categories = await _categoryRepository.GetAll();
            return Ok(categories); 
        }
    }
}