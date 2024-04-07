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
    public partial class AddDetail : Form
    {
        public OrderDetails NewDetail { get; private set; }
        public AddDetail()
        {
            InitializeComponent();
        }

        private void button_addDetail_2_Click(object sender, EventArgs e)
        {
            NewDetail = new OrderDetails {Product = new Product{ Name = textBox_product.Text,Price =Convert.ToDecimal(textBox_price.Text)} ,Quantity = Convert.ToInt32(textBox_quantity.Text)};
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
