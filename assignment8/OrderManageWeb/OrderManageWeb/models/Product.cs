using System.ComponentModel.DataAnnotations;

namespace OrderManageWeb.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ?Name { get; set; }
        public decimal Price { get; set; }
        // Other properties
    }
}
