using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name="Milk", Quantity= 1, Price=2}
            };
            return Ok(products);
        }
    }
}
