using DemoWebApi_säkerhet.Core.Interfaces;
using DemoWebApi_säkerhet.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_säkerhet.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous] //Detta är egentligen default men kan vara tydligt att ange
        [Route("api/login")]
        public IActionResult Login(User user)
        {

            if (_service.Login(user))
            {
                string tokenString = _service.GenerateToken(user);
                return Ok(new { token = tokenString });
            }
            else
            {
                return Unauthorized("Felaktig inloggning");
            }
        }
    }
}
