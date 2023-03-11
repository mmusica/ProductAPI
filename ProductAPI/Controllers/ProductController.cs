using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
                new Product { Id = 1, Name="Milk", Quantity= 1, Price=2}
            };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            
            return Ok(products);
        }
        [HttpPost]

        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            products.Add(product);
            return Ok(products);
        }
    }
}
