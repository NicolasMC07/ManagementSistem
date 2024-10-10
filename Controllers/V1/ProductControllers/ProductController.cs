using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Controllers.V1.ProductControllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        protected readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}