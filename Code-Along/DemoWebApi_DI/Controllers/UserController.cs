using DemoWebApi_DI.Core.Interfaces;
using DemoWebApi_DI.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_DI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    // Här injectar vi via konstruktorn. En ny instans skapas via
    // service containern i program.cs
    public UserController(IUserService userService)
    {
        _userService = userService;
    } 

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok(_userService.GetAllUsers());
    }

    // POST api/User  (login)
    [HttpPost]
    public IActionResult Login(User user)
    {
        bool login = _userService.Login(user);

        if (!login)
            return Unauthorized("Fel användarnamn eller lösenord.");

        return Ok("Logged in");
    }

    // POST api/User/register
    [HttpPost("register")]
    public IActionResult Register(User user)
    {
        try
        {
            var created = _userService.Register(user);
            return Created($"/api/User/{created.UserID}", created);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return Conflict(ex.Message);
        }
    }

    [HttpDelete("{userId:int}")]
    public IActionResult Delete(int userId)
    {
        bool deleted = _userService.Delete(userId);

        if (!deleted)
            return NotFound($"Ingen user med id {userId}.");

        return Ok("User raderad");
    }
}
