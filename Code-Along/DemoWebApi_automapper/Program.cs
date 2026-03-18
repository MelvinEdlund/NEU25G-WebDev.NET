using DemoWebApi_automapper.Core.Interfaces;
using DemoWebApi_automapper.Core.Services;
using DemoWebApi_automapper.Data.Interfaces;
using DemoWebApi_automapper.Data.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(Program));

// Repot skall alltid sättas upp med addscoped
builder.Services.AddScoped<IPersonRepo, PersonRepo>();

// Servicen beror på. Kan sättas upp i vissa fall med addscoped
// och i vissa fall addtransient
builder.Services.AddTransient<IPersonService, PersonService>();


var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
