using DemoWebApi_DB.Data.Entities;

namespace DemoWebApi_DB.Core.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();

    void AddProduct(Product product);
}
