using DemoWebApi_DB.Core.Interfaces;
using DemoWebApi_DB.Data.Entities;
using DemoWebApi_DB.Data.Interfaces;

namespace DemoWebApi_DB.Core.Services;

public class ProductService : IProductService
{
    private readonly IProductRepo _repo;

    public ProductService(IProductRepo repo)
    {
        _repo = repo;
    }

    public void AddProduct(Product product)
    {
        _repo.AddProduct(product);
    }

    public List<Product> GetAllProducts()
    {
        return _repo.GetAllProducts();
    }
}
