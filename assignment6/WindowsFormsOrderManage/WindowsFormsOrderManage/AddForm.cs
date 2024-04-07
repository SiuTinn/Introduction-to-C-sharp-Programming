using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManage;

namespace WindowsFormsOrderManage
{
    public partial class AddForm : Form
    {
        public Order NewOrder { get; set; }
        public AddForm()
        {
            InitializeComponent();
        }

        private void button_add_2_Click(object sender, EventArgs e)
        {
            NewOrder = new Order { Id = Convert.ToInt32(textBox_Id.Text), Customer = new Customer { Name = textBox_cname.Text } };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
