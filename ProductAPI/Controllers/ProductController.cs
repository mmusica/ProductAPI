using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> products = new List<Product>
        {
                new Product { Id = 1, Name="Milk", Quantity= 1, Price=2},
                new Product { Id = 2, Name="Bread", Quantity= 2, Price=1}
            };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {

            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product == null)
            {
                return BadRequest("Product not found");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<List<Product>>> AddProduct(Product product)
        {
            products.Add(product);
            return Ok(products);
        }
    }
}
