using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_introduktion.Controllers
{

    // Routen för denna controller blir "http://localhost:5065/api/student"
    [Route("api/[controller]")]
    [ApiController]

    // ControllerBase är en basklass som gör att metoderna i klassen
    // Kan ta emot anrop via http och skicka tillbaka svar
    public class StudentController : ControllerBase
    {
        // Man anger vilken httpmetod som metoden skall svara på
        [HttpGet]

        // En metod i ett web api kallas för endpoint
        //(eller möjligtvis action metod)
        public IActionResult sayHello()
        {

            // Ett webapi brukar skicka tillbaka statuskoder
            // OK = 200, allt gick bra
            return Ok("Hello world");
        }

    }
}
