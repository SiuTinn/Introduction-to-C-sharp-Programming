namespace OrderManage.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class OrderServiceTests
        {
            private OrderService _orderService;

            [TestInitialize]
            public void TestInitialize()
            {
                _orderService = new OrderService();

                // 初始化一些测试数据
                var order1 = new Order
                {
                    Id = 1,
                    Customer = new Customer { Name = "Alice" },
                    Detail = new List<OrderDetails>
                {
                    new OrderDetails { Product = new Product { Name = "Laptop", Price = 1000 }, Quantity = 1 }
                }
                };

                var order2 = new Order
                {
                    Id = 2,
                    Customer = new Customer { Name = "Bob" },
                    Detail = new List<OrderDetails>
                {
                    new OrderDetails { Product = new Product { Name = "Smartphone", Price = 500 }, Quantity = 2 }
                }
                };

                _orderService.AddOrder(order1);
                _orderService.AddOrder(order2);
            }

            [TestMethod]
            public void AddOrder_WhenCalled_AddsOrderToService()
            {
                var newOrder = new Order
                {
                    Id = 3,
                    Customer = new Customer { Name = "Charlie" },
                    Detail = new List<OrderDetails>
                {
                    new OrderDetails { Product = new Product { Name = "Tablet", Price = 600 }, Quantity = 1 }
                }
                };

                _orderService.AddOrder(newOrder);

                Assert.IsTrue(_orderService.GetAllOrders().Contains(newOrder));
            }

            [TestMethod]
            public void RemoveOrder_ExistingOrderId_RemovesOrder()
            {
                _orderService.DeleteOrder(1);

                Assert.IsFalse(_orderService.GetAllOrders().Any(o => o.Id == 1));
            }

            [TestMethod]
            public void UpdateOrder_WithExistingOrder_UpdatesOrder()
            {
                var updatedOrder = new Order
                {
                    Id = 1,
                    Customer = new Customer { Name = "Alice Updated" },
                    Detail = new List<OrderDetails>
                {
                    new OrderDetails { Product = new Product { Name = "Laptop", Price = 1200 }, Quantity = 1 }
                }
                };

                _orderService.UpdateOrder(1, updatedOrder);

                var order = _orderService.GetOrder(1);
                Assert.AreEqual("Alice Updated", order.Customer.Name);
                Assert.AreEqual(1200, order.Detail.First().Product.Price);
            }

            [TestMethod]
            public void GetOrder_ExistingOrderId_ReturnsOrder()
            {
                var order = _orderService.GetOrder(1);

                Assert.IsNotNull(order);
                Assert.AreEqual(1, order.Id);
            }

            [TestMethod]
            public void GetAllOrders_AfterAddingOrders_ReturnsAllOrders()
            {
                var orders = _orderService.GetAllOrders();

                Assert.AreEqual(2, orders.Count());
            }


            [TestCleanup]
            public void TestCleanup()
            {
            }
        }
    }
}