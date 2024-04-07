using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class Order
    {
        public int Id { get; set; }   //Order ID
        public List<OrderDetails> Detail { get; set; } = new List<OrderDetails>();
        //a order may have many types of products
        public Customer Customer { get; set; }
        public decimal Total_Amount
        {get
            {
                return Detail.Sum(detail => detail.Quantity * detail.Product.Price);
            }
        }
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   Id == order.Id;
        }
        public override int GetHashCode() => Id;

        public override string ToString()
        {
            return $"OrderId: {Id}, Customer: {Customer}, TotalAmount: {Detail.Sum(detail => detail.Quantity * detail.Product.Price)}";
        }
    }
}
