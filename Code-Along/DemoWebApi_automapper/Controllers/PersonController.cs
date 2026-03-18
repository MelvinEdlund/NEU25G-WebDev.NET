using DemoWebApi_automapper.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_automapper.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly IPersonService _service;

    public PersonController(IPersonService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public IActionResult GetPerson(int id)
    {
        // Här returneras data i PersonDTO format
        return Ok(_service.GetPerson(id));
    }
}
