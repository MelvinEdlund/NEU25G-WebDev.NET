using DemoWebApi_DB.Core.Interfaces;
using DemoWebApi_DB.Core.Services;
using DemoWebApi_DB.Data;
using DemoWebApi_DB.Data.Interfaces;
using DemoWebApi_DB.Data.Repos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var connString = "Data Source=localhost,1433; Initial Catalog=ProductDB;User Id=sa;Password=StrongPassword123!; TrustServerCertificate=True;";

// Vi sätter upp EF med dependency injection. Innebär att en context behöver injectas via konstruktorn.
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(connString)
);

// Vi sätter upp repo och service med DI för att få lösa kopplingar
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepo, ProductRepo>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoint => { endpoint.MapControllers(); });

app.Run();
