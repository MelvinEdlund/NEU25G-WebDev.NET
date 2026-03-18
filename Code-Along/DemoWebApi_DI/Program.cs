using DemoWebApi_DI.Core.Interfaces;
using DemoWebApi_DI.Core.Services;
using DemoWebApi_DI.Data.Interfaces;
using DemoWebApi_DI.Data.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Här sätter vi upp service och repo med DI. Detta ger en lösare koppling
builder.Services.AddScoped<IUserService, UserService>();

// Singleton => samma repo-instans används för alla requests (in-memory state “lever kvar”)
builder.Services.AddSingleton<IUserRepo, UserRepo>();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); }); ;

app.Run();
