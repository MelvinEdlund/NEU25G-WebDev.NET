using DemoWebApi_DB.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoWebApi_DB.Data;

// Genom att klassen ärver från basklassen Dbcontext kan den kommunicera med en databas
// och skicka olika typer av anrop
public class ProductContext : DbContext
{
    // En konstruktor behövs för att kunna skicka in parametrar
    // Ex connection string
    public ProductContext(DbContextOptions options) : base(options)
    {

    }

    // Detta är det sätt vi mappar en tabell i databasen med en lista med objekt
    public virtual DbSet<Product> Products { get; set; }
}
