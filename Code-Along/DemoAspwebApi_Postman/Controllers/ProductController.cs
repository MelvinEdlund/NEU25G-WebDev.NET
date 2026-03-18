using DemoAspwebApi_Postman.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspwebApi_Postman.Controllers
{
    // Routern kommer att se ut så här "http://localhost:5140/api/product"
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        [HttpGet("{condition}")]
        public IActionResult ProductSearch(string condition)
        {
            // Villkor som testar inparametrar 
            if (condition == null || condition == "")
                return BadRequest();


            var products = new List<Product>
            {
                new Product(1, "Iphone 17e", 8799),
                new Product(2, "Iphone 16e", 7599),
                new Product(3, "Samsung S26", 9999)



            };

            var result = products
                .Where(p => p.ProductName
                .Contains(condition))
                .ToList();

            return Ok(result);

        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {

            return Ok("Produkten är sparad");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id) => Ok("Produkten togs bort.");
    }
}
