using System.ComponentModel.DataAnnotations;

namespace DemoWebApi_DB.Data.Entities;

public class Product
{
    // Vi talar om att productid skall bli en primärnyckel i databasen
    [Key]
    public int ProductID { get; set; }

    [Required]
    [StringLength(70)]
    public string ProductName { get; set; }

    public int Price { get; set; }

    [StringLength(100)]
    public string Description { get; set; }
}
