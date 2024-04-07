using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Any(o => o.Id == order.Id))
            {
                throw new Exception("An order with the same ID already exists.");
            }
            orders.Add(order);
        }

        public Order GetOrder(int orderId)
        {
            return orders.FirstOrDefault(o => o.Id == orderId);
        }

        public List<Order> GetAllOrders()
        {
            return new List<Order>(orders);
        }

        public void UpdateOrder(int orderId, Order newOrder)
        {
            var orderIndex = orders.FindIndex(o => o.Id == orderId);
            if (orderIndex == -1)
            {
                throw new Exception("Order not found.");
            }
            newOrder.Id = orderId; // 确保新订单保持相同的订单ID
            orders[orderIndex] = newOrder;
        }

        public void DeleteOrder(int orderId)
        {
            if (orders.All(o => o.Id != orderId))
            {
                throw new Exception("This order is not exist");
            }
            orders.RemoveAll(o=>o.Id==orderId);
        }

        public List<Order> SearchByOrderNumber(int orderNumber)
        {
            var query = from order in orders
                        where order.Id == orderNumber
                        orderby order.Detail.Sum(d => d.Quantity * d.Product.Price) descending
                        select order;
            return query.ToList();
        }

        public IEnumerable<Order> SearchByProductName(string productName)
        {
            var query = from order in orders
                        from detail in order.Detail
                        where detail.Product.Name.Contains(productName)
                        orderby order.Detail.Sum(d=>d.Quantity * d.Product.Price) descending
                        select order;
            return query.Distinct();
            
        }

        public List<Order> SearchByCustomerName(string customerName)
        {
            var query = from order in orders
                        where order.Customer.Name.Contains(customerName)
                        orderby order.Detail.Sum(d => d.Quantity * d.Product.Price) descending
                        select order;
            return query.ToList();
        }

        public List<Order> SearchByOrderAmount(decimal amount)
        {
            var query = from order in orders
                        let totalAmount = order.Detail.Sum(d => d.Quantity * d.Product.Price)
                        where totalAmount == amount
                        orderby totalAmount descending
                        select order;
            return query.ToList();
        }




    }


}
