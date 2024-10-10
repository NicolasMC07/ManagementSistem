using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.DTOs;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ManagementSystem.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductUpdateController : ProductController
    {
        // Constructor to inject the product repository
        public ProductUpdateController(IProductRepository productRepository) : base(productRepository)
        {
        }

        [HttpPut("/api/v1/categories/{id} ")] // Specifies the HTTP PUT method for updating a product by ID
        [SwaggerOperation(
            Summary = "Update product information",
            Description = "Updates the details of an existing product identified by the provided ID."
        )]
        public async Task<IActionResult> Update(int id, ProductDTO productDTO)
        {
            // Validate the model state; return BadRequest if invalid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Retrieve the existing product by ID
            var existProduct = await _productRepository.GetById(id);
            if (existProduct == null)
            {
                return NotFound(); // Return NotFound if the product does not exist
            }

            // Update product properties with the new data from productDTO
            existProduct.Name = productDTO.Name;
            existProduct.Description = productDTO.Description;
            existProduct.Price = productDTO.Price;
            existProduct.CategoryId = productDTO.CategoryId;

            // Call the repository to update the product record
            await _productRepository.Update(existProduct);

            return NoContent(); // Return NoContent to indicate successful update
        }
    }
}