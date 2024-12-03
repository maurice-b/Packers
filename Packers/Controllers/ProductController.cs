using Microsoft.AspNetCore.Mvc;
using Packers.Models;

namespace Packers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public object GetProduct()
        {
            return new Product()
            {
                Id = 1,
                 Name = "Test",
                 Price= 1.95m,
                 StockQuantity=100
            };
        }
    }
}
