using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OrderManage
{
    class Program
    {
        private static OrderService orderService = new OrderService();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nOrder Management System");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Add Order Detail");
                Console.WriteLine("3. Display All Orders");
                Console.WriteLine("4. Update Order");
                Console.WriteLine("5. Delete Order");
                Console.WriteLine("6. Search Order");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddOrder();
                        break;
                    case "2":
                        AddOrderDetail();
                        break;
                    case "3":
                        DisplayAllOrders();
                        break;
                    case "4":
                        UpdateOrder();
                        break;
                    case "5":
                        DeleteOrder();
                        break;
                    case "6":
                        SearchOrders();
                        break;
                    case "7":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine(new string('-', 80));
                        break;
                }

            }

            void AddOrder()
            {
                try
                {
                    Console.Write("Enter Order ID: ");
                    int orderId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Customer Name: ");
                    string customerName = Console.ReadLine();

                    Order order = new Order { Id = orderId, Customer = new Customer { Name = customerName } };

                    orderService.AddOrder(order);
                    Console.WriteLine("Order added successfully.");
                    Console.WriteLine(new string('-', 80));

                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error adding order: {e.Message}");
                    Console.WriteLine(new string('-', 80));
                }
            }

            void AddOrderDetail()
            {
                try
                {
                    Console.Write("Enter Order ID to which the detail will be added: ");
                    int orderId = int.Parse(Console.ReadLine());
                    var order = orderService.GetOrder(orderId);
                    if (order == null)
                    {
                        Console.WriteLine("Order not found.");
                        Console.WriteLine(new string('-', 80));
                        return;
                    }

                    Console.Write("Enter Product Name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Enter Product Price: ");
                    decimal price = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    Product product = new Product { Name = productName, Price = price };
                    OrderDetails detail = new OrderDetails { Product = product, Quantity = quantity };
                    order.Detail.Add(detail);
                    Console.WriteLine("Order detail added successfully.");
                }
                catch (Exception e) { Console.WriteLine(e.Message); }
            }

            void DisplayAllOrders()
            {
                var orders = orderService.GetAllOrders();
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                    foreach (var detail in order.Detail)
                    {
                        Console.WriteLine($"\t{detail}");
                    }
                }
                Console.WriteLine(new string('-', 80));
            }

            void UpdateOrder()
            {
                try
                {
                Console.Write("Enter Order ID to update: ");
                int orderId = int.Parse(Console.ReadLine());
                var existingOrder = orderService.GetOrder(orderId);
                if (existingOrder == null)
                {
                    Console.WriteLine("Order not found.");
                    return;
                }

                Console.Write("Enter new Customer Name: ");
                string newCustomerName = Console.ReadLine();
                Order newOrder = new Order
                {
                    Customer = new Customer { Name = newCustomerName },
                    Detail = new List<OrderDetails>() // 初始化新订单明细列表
                };           
                    orderService.UpdateOrder(orderId, newOrder);
                    Console.WriteLine("Order updated successfully. Please renew the details.");
                    Console.WriteLine(new string('-', 80));
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error updating order: {e.Message}");
                    Console.WriteLine(new string('-', 80));
                }
            }

            void DeleteOrder()
            {
                try
                {
                    Console.WriteLine("Enter the Order Id to delete: ");
                    int orderId = Convert.ToInt32(Console.ReadLine());
                    orderService.DeleteOrder(orderId);
                    Console.WriteLine("Order deleted successfully.");
                    Console.WriteLine(new string('-', 80));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(new string('-', 80));
                }
            }

            void SearchOrders()
            {
                Console.WriteLine("Search Orders");
                Console.WriteLine("1. By Order Number");
                Console.WriteLine("2. By Product Name");
                Console.WriteLine("3. By Customer Name");
                Console.WriteLine("4. By Order Amount");
                Console.Write("Select an option: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter Order Number: ");
                        int orderNumber = int.Parse(Console.ReadLine());
                        DisplayOrders(orderService.SearchByOrderNumber(orderNumber));
                        break;
                    case "2":
                        Console.Write("Enter Product Name: ");
                        string productName = Console.ReadLine();
                        DisplayOrders(orderService.SearchByProductName(productName));
                        break;
                    case "3":
                        Console.Write("Enter Customer Name: ");
                        string customerName = Console.ReadLine();
                        DisplayOrders(orderService.SearchByCustomerName(customerName));
                        break;
                    case "4":
                        Console.Write("Enter Order Amount: ");
                        decimal amount = decimal.Parse(Console.ReadLine());
                        DisplayOrders(orderService.SearchByOrderAmount(amount));
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            void DisplayOrders(IEnumerable<Order> orders)
            {
                foreach (var order in orders)
                {
                    Console.WriteLine(order);
                    foreach (var detail in order.Detail)
                    {
                        Console.WriteLine($"\t{detail}");
                    }
                }
                if (!orders.Any())
                {
                    Console.WriteLine("No orders found.");
                    Console.WriteLine(new string('-', 80));
                }
                Console.WriteLine(new string('-', 80));
            }

        }
    }
}
