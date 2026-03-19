using DemoFullstack1_backend.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoFullstack1_backend.Controller;

[Route("api/[controller]")]
[ApiController]
public class TodoController : ControllerBase
{
    private readonly ITodoService _service;

    public TodoController(ITodoService service)
    {
        _service = service;
    }

    [HttpGet("{condition}")]
    public IActionResult SearchTodo(string condition)
    {
        return Ok(_service.SearchTodo(condition));
    }
}
