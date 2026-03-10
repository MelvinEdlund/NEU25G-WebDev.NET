using DemoAspWebApi_CRUD.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoAspWebApi_CRUD.Data
{
    public class ProductContext : DbContext
    {
        //Här sätts options som skickas med när contexten sätts upp med DI
        //Exempel på detta är connectionsträngen
        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        //Detta blir en tabell i databasen
        public virtual DbSet<Product> Products { get; set; }
       
    }
}
