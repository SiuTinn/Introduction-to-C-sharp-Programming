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
    public partial class UpdataForm : Form
    {
        public string NewCName{ get; private set; }
        public UpdataForm()
        {
            InitializeComponent();
        }

        private void button_update_2_Click(object sender, EventArgs e)
        {
            NewCName = textBox_newCname.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
