using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.DTOs;
using ManagementSystem.Models;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductCreateController : ProductController
    {
        // Constructor to inject the product repository
        public ProductCreateController(IProductRepository productRepository) : base(productRepository)
        {
        }

        [HttpPost("/api/v1/categories")]
        [SwaggerOperation(
            Summary = "Create a new product",
            Description = "Creates a new product record for a specified room and guest, ensuring all provided data is valid."
        )]
        public async Task<IActionResult?> Create(ProductDTO productDTO)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Create a new product object from the provided productDTO
            var newProduct = new Product(
                productDTO.Name,
                productDTO.Description,
                productDTO.Price,
                productDTO.CategoryId
            );

            // Call the repository to save the new product
            await _productRepository.Create(newProduct);

            // Return the created product object as a response
            return Ok(newProduct);
        }
    }
}