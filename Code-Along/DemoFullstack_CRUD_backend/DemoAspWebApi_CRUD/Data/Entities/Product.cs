using System.ComponentModel.DataAnnotations;

namespace DemoAspWebApi_CRUD.Data.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(60)]
        public string ProductName { get; set; }

        public int Price { get; set; }

    }
}
