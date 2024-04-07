using OrderManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrderManage
{
    public partial class MainForm : Form
    {

        public List<Order> orders;
        public OrderService orderService = new OrderService();
        public int searchType;
        public List<Order> ordersSearch;
        public MainForm()
        {
            InitializeComponent();
            Order order_test1 = new Order { Id = 1, Customer = new Customer { Name = "xxt" } };
            Order order_test2 = new Order { Id = 2, Customer = new Customer { Name = "lxq" } };
            orderService.AddOrder(order_test1);
            orderService.AddOrder(order_test2);
            OrderDetails detail_1 = new OrderDetails { Product = new Product { Name = "good", Price = 1 }, Quantity = 10 };
            OrderDetails detail_2 = new OrderDetails { Product = new Product { Name = "love", Price = 1 }, Quantity = 5 };
            order_test1.Detail.Add(detail_1);
            order_test2.Detail.Add(detail_2);
            InitializeDataGridView();
        }

        private void LoadData()
        {
            ordersSearch = orderService.GetAllOrders();
            dataGridViewMain.DataSource = ordersSearch;
        }

        private void LoadDataBySearch()
        {
            dataGridViewMain.DataSource = ordersSearch;
        }
        private void InitializeDataGridView()
        {
            dataGridViewMain.AutoGenerateColumns = true;
            dataGridViewMain.SelectionChanged += dataGridViewMain_SelectionChanged;
            dataGridViewDetails.AutoGenerateColumns = true;
            LoadData();
        }

        private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentRow != null)
            {
                var currentOrder = dataGridViewMain.CurrentRow.DataBoundItem as Order;
                if (currentOrder != null)
                {
                    dataGridViewDetails.DataSource = currentOrder.Detail;
                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                Order newOrder = addForm.NewOrder;
                try
                {
                    orderService.AddOrder(newOrder);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An order with the same ID already exists.");
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentRow != null)
            {
                var currentOrder = dataGridViewMain.CurrentRow.DataBoundItem as Order;
                if (currentOrder != null)
                {
                    try
                    {
                        orderService.DeleteOrder(currentOrder.Id);
                        MessageBox.Show($"Order {currentOrder.Id} has been successfully deleted.", "Order Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the order:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void radioButton_CheckedChange(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked && radioButton != null)
            {
                switch (radioButton.Text)
                {
                    case "Id":
                        searchType = 1;
                        break;
                    case "Customer":
                        searchType = 2;
                        break;
                    case "Amount":
                        searchType = 3;
                        break;
                }
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (radioButton_id.Checked)
            {
                int id = Convert.ToInt32(textBox_search.Text);
                ordersSearch = orderService.SearchByOrderNumber(id);
                LoadDataBySearch();
            }
            else if (radioButton_cname.Checked)
            {
                string cname = textBox_search.Text;
                ordersSearch = orderService.SearchByCustomerName(cname);
                LoadDataBySearch();
            }
            else if (radioButton_amount.Checked)
            {
                decimal amount = Convert.ToDecimal(textBox_search.Text);
                ordersSearch = orderService.SearchByOrderAmount(amount);
                LoadDataBySearch();
            }
        }

        private void button_addDetail_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentRow != null)
            {
                var currentOrder = dataGridViewMain.CurrentRow.DataBoundItem as Order;
                if (currentOrder != null)
                {
                    try
                    {
                        AddDetail addDetail = new AddDetail();
                        if(addDetail.ShowDialog()== DialogResult.OK)
                        {
                            OrderDetails newOrderDetail = addDetail.NewDetail;
                            currentOrder.Detail.Add(newOrderDetail);
                            LoadData();
                            dataGridViewDetails.DataSource = currentOrder.Detail;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the order:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain.CurrentRow != null)
            {
                var currentOrder = dataGridViewMain.CurrentRow.DataBoundItem as Order;
                if (currentOrder != null)
                {
                    try
                    {
                        UpdataForm updataForm = new UpdataForm();
                        if (updataForm.ShowDialog() == DialogResult.OK)
                        {
                            string newCname = updataForm.NewCName;
                            Order newOrder = new Order {Id = currentOrder.Id,Customer = new Customer { Name = newCname} };
                            orderService.UpdateOrder(currentOrder.Id, newOrder);
                            LoadData();
                            dataGridViewDetails.DataSource = currentOrder.Detail;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the order:{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
