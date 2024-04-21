using Microsoft.EntityFrameworkCore;

namespace OrderManageWeb.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options)
        : base(options)
        {
            this.Database.EnsureCreated(); //自动建库建表
        }
    }
}
