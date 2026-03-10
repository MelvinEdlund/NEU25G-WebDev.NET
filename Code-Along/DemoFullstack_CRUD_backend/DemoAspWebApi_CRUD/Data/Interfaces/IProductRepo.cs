using DemoAspWebApi_CRUD.Data.Entities;

namespace DemoAspWebApi_CRUD.Data.Interfaces
{
    public interface IProductRepo
    {
        List<Product> GetAllProducts();

        void AddProduct(Product product);

        void UpdateProduct(Product product);
        void DeleteProduct(int id);

    }
}
