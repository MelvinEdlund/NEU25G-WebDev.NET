using DemoAspWebApi_CRUD.Data;
using DemoAspWebApi_CRUD.Data.Interfaces;
using DemoAspWebApi_CRUD.Data.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connString = "Server=localhost,1433;Database=ProductDB;User Id=sa;Password=StrongPassword123!;TrustServerCertificate=True;";
//Skapar upp EF som en service som kan injectas till repot
builder.Services.AddDbContext<ProductContext>(options =>

    options.UseSqlServer(connString)
);

//Vi lägger på CORS som en service. Detta behövs eftersom vår frontend kommer att köras på en 
//annan domän
builder.Services.AddCors();

//Sätter upp repot så att det kan injectas i controllern
builder.Services.AddScoped<IProductRepo, ProductRepo>();

var app = builder.Build();

app.UseRouting();

//Vi tillåter alla origins och alla metoder och header. Inte så bra säkerhetsmässigt men
//funkar nu för denna demon
app.UseCors(options =>
    options.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()

);

app.UseEndpoints(endpoints => {  endpoints.MapControllers(); });


app.Run();
