using OrderManageEF;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static OrderRepository repository = new OrderRepository();

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Please choose an operation:");
            Console.WriteLine("1 - Add New Order");
            Console.WriteLine("2 - Display All Orders");
            Console.WriteLine("3 - Update Existing Order");
            Console.WriteLine("4 - Delete Order");
            Console.WriteLine("5 - Exit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddOrder();
                    break;
                case "2":
                    DisplayOrders();
                    break;
                case "3":
                    UpdateOrder();
                    break;
                case "4":
                    DeleteOrder();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, 3, 4, or 5.");
                    break;
            }
        }
    }

    static void AddOrder()
    {
        Console.WriteLine("Enter customer name:");
        var customerName = Console.ReadLine();

        var order = new Order
        {
            OrderDate = DateTime.Now,
            CustomerName = customerName,
            Details = new List<OrderDetail>()
        };

        string addMore;
        do
        {
            Console.WriteLine("Enter product name:");
            var productName = Console.ReadLine();
            Console.WriteLine("Enter price:");
            var price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity:");
            var quantity = int.Parse(Console.ReadLine());

            order.Details.Add(new OrderDetail
            {
                ProductName = productName,
                Price = price,
                Quantity = quantity
            });

            Console.WriteLine("Add more items to the order? (yes/no)");
            addMore = Console.ReadLine();
        } while (addMore.ToLower() == "yes");

        repository.AddOrder(order);
        Console.WriteLine("Order added successfully.");
    }

    static void DisplayOrders()
    {
        var orders = repository.GetAllOrders();
        if (!orders.Any())
        {
            Console.WriteLine("No orders found.");
            return;
        }

        foreach (var order in orders)
        {
            Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.CustomerName}, Date: {order.OrderDate.ToShortDateString()}");
            foreach (var detail in order.Details)
            {
                Console.WriteLine($"  {detail.ProductName} - ${detail.Price} x {detail.Quantity}");
            }
            Console.WriteLine();
        }
    }

    static void UpdateOrder()
    {
        Console.WriteLine("Enter Order ID to update:");
        var orderId = int.Parse(Console.ReadLine());
        var order = repository.GetAllOrders().FirstOrDefault(o => o.OrderId == orderId);

        if (order == null)
        {
            Console.WriteLine("Order not found.");
            return;
        }

        Console.WriteLine("Enter new customer name (leave blank to keep current):");
        var newName = Console.ReadLine();
        if (!string.IsNullOrEmpty(newName))
        {
            order.CustomerName = newName;
        }

        repository.UpdateOrder(order);
        Console.WriteLine("Order updated successfully.");
    }

    static void DeleteOrder()
    {
        Console.WriteLine("Enter Order ID to delete:");
        var orderId = int.Parse(Console.ReadLine());
        repository.DeleteOrder(orderId);
        Console.WriteLine("Order deleted successfully.");
    }
}
