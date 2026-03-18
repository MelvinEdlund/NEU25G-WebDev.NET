using DemoWebApi_DB.Data.Entities;

namespace DemoWebApi_DB.Data.Interfaces;

public interface IProductRepo
{
    List<Product> GetAllProducts();

    void AddProduct(Product product);
}
