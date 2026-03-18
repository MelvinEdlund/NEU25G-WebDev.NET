using DemoWebApi_DB.Data.Entities;
using DemoWebApi_DB.Data.Interfaces;

namespace DemoWebApi_DB.Data.Repos;

public class ProductRepo : IProductRepo
{
    private readonly ProductContext _context;

    // Nya instanser av contexten skapas via service container i program.cs
    // Injectas via konstruktorn
    public ProductRepo(ProductContext context)
    {
        _context = context;
    }

    // Viktigt! All EF kod skall ligga i repos. Inte något i tex controllers eller services
    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public List<Product> GetAllProducts()
    {
        return _context.Products.ToList();
    }
}
