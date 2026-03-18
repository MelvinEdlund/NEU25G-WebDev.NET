namespace DemoAspwebApi_Postman.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public Product(int productId, string productName, int price)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
        }
    }
}
