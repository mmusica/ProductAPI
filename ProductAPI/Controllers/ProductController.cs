﻿using Microsoft.AspNetCore.Mvc;

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
        [HttpPut]
        public async Task<ActionResult<List<Product>>> UpdateProduct(Product request)
        {
            var foundProduct = products.Find(x => x.Id == request.Id);
            if (foundProduct == null)
            {
                return BadRequest("Product not found");
            }
            else
            {
                foundProduct.Id = request.Id;
                foundProduct.Name = request.Name;
                foundProduct.Quantity = request.Quantity;
                foundProduct.Price = request.Price;
            }
            return Ok(products);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Product>>> DeleteProduct(int id)
        {
            var foundProduct = products.Find(x => x.Id == id);
            if (foundProduct == null)
            {
                return BadRequest("Product not found");
            }
            else
            {
                products.Remove(foundProduct);
            }
           
            return Ok(products);
        }

    }
}
