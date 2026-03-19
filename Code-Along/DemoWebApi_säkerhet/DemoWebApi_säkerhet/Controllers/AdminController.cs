using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_säkerhet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Bara användare med admin behörighet kan komma åt dessa endpoints
    [Authorize(Roles ="Admin")]

    public class AdminController : ControllerBase
    {

        [HttpGet]
  
        public IActionResult CheckAdmin()
        {
            return Ok(new { message="Logged in as admin"});
        }
    }
}
