using DemoFullstack1_backend.Core.Interfaces;
using DemoFullstack1_backend.Core.Services;
using DemoFullstack1_backend.Data.Interfaces;
using DemoFullstack1_backend.Data.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddScoped<ITodoRepo, TodoRepo>();
builder.Services.AddScoped<ITodoService, TodoService>();

var app = builder.Build();


// Enkelt men mindre säkert sätt att skapa en CORS policy,
// Vi tillåter anrop från alla externa domäner
app.UseCors(options =>

    options.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()

);

app.UseRouting();
app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
