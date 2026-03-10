using DemoAspWebApi_CRUD.Data.Entities;
using DemoAspWebApi_CRUD.Data.Interfaces;

namespace DemoAspWebApi_CRUD.Data.Repos
{
    public class ProductRepo : IProductRepo
    {
        private readonly ProductContext _context;

        //Contexten sätts upp i service containern och injectas till 
        //denna klassen via konstruktorn
        public ProductRepo(ProductContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product= _context.Products.SingleOrDefault(p=> p.ProductID==id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void UpdateProduct(Product productUpdated)
        {
            //Hämta den product som skall uppdateras
            var productOrg = _context.Products
                .SingleOrDefault(p => p.ProductID == productUpdated.ProductID);

            _context.Entry(productOrg).CurrentValues.SetValues(productUpdated);
            _context.SaveChanges();


        }
    }
}
