using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using MySql.Data.EntityFramework;

namespace OrderManageEF
{
    public class OrderRepository
    {
        public void AddOrder(Order order)
        {
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        public IEnumerable<Order> GetAllOrders()
        {
            using (var context = new OrderContext())
            {
                return context.Orders.Include(o => o.Details).ToList();
            }
        }

        public void UpdateOrder(Order order)
        {
            using (var context = new OrderContext())
            {
                context.Entry(order).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (var context = new OrderContext())
            {
                var order = context.Orders.Find(orderId);
                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
        }
    }
}
