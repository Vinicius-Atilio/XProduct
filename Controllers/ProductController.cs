using api.Entities;
using api.Service;
using api.Repository;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService productService;
        private readonly ILogger<ProductController> logger;

        public ProductController(ProductService productService, ILogger<ProductController> logger)
        {
            this.productService = productService;
            this.logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            Console.WriteLine(id);
            return await productService.GetProductById(id);
        }
    }
}