using DemoWebApi_säkerhet.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_säkerhet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        //Denna enpoint kräver en inloggning men inte att man har en speciell roll
        [Authorize]
        public IActionResult GetProducts()
        {
            var list = new List<Product>()
            {
                new Product(1,"Iphone"),
                new Product(2,"Samsung")



            };

            return Ok(list);


        }
    }
}
