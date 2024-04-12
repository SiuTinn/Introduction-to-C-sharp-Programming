using System;
using System.Data.Entity;
using System.Linq;
using MySql.Data.EntityFramework;
using MySql.Data.MySqlClient;

namespace OrderManageEF
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public OrderContext() : base("name=OrderContext")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderItems { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}