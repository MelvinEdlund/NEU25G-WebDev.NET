using DemoWebApi_DB.Core.Interfaces;
using DemoWebApi_DB.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_DB.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service)
    {
        _service = service;
    }

    [HttpGet]
    [Route("alternativ1")]
    public IActionResult GetAllProducts()
    {
        return Ok(_service.GetAllProducts());
    }

    [HttpGet]
    [Route("alternativ2")]
    public IActionResult SearchProducts(string condition)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        _service.AddProduct(product);
        return Ok(product);
    }
}
