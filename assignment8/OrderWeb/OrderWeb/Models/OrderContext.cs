using Microsoft.EntityFrameworkCore;
using OrderApi.Models;

namespace OrderWeb.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options)
         : base(options)
        {
            Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
    }
}