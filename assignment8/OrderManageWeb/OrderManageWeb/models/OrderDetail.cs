using System.ComponentModel.DataAnnotations;

namespace OrderManageWeb.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public Product ?Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }  // Assume price is recorded at the time of order
    }
}
