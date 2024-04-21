using System.ComponentModel.DataAnnotations;

namespace OrderManageWeb.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderDetail> ?OrderDetails { get; set; }
        public int CustomerId { get; set; }
        public Customer ?Customer { get; set; }
    }
}
