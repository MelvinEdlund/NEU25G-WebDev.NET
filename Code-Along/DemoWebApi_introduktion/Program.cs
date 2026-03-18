
// Detta är en mycket central fil. Här sätter man upp och konfigurerar upp hela sitt projekt
// Består av två huvuddelar

//1. Första delen kallas för en service (DI) container. Här sätts olika tjänster upp
// Som skall användas i applikationen. 

var builder = WebApplication.CreateBuilder(args);

// Här sätter vi upp projektet att det skall vara ett web api som använder controllers.
builder.Services.AddControllers();


//2. Den andra delen som kallas för en request pipeline 
var app = builder.Build();

//Routing handlar om att mappa url:en med rätt metod i en controller
app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
