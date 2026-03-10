using DemoAspWebApi_CRUD.Data.Entities;
using DemoAspWebApi_CRUD.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoAspWebApi_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //Här skall vi ha CRUD funktionalitet mot databasen. Innebär att vi skall ha
        //endpoint som stöder GET, POST, PUT, DELETE
        private readonly IProductRepo _repo;

        public ProductController(IProductRepo repo)
        {
            _repo = repo;
        }

        //Endpoints i en controller skall vara tunna och inte innehålla
        //mycket kod. Bara ta emot en request och skicka den vidare till repot
        //och sedan skicka tillbaka en response
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_repo.GetAllProducts());
        }

        
        [HttpPost]
        public IActionResult AddProduct(Product product) { 
            
            _repo.AddProduct(product);

            return Created();
        
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product product) {

            _repo.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(Product product) { 
        
            if(product.ProductID <= 0 )
                return BadRequest();

            _repo.DeleteProduct(product.ProductID);
            return Ok();
        
        }


    }
}
