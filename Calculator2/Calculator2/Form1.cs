namespace Calculator2
{
    public partial class Form1 : Form
    {
        private int firstNum; //第一个数
        private string operator_str; //操作符


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "1";
            }
            else
            {
                textBox.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "2";
            }
            else
            {
                textBox.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text += "0";
            }
        }


        // + - * /
        private void btn_operator_click(object sender, EventArgs e)
        {
            firstNum = Convert.ToInt32(textBox.Text);  //按下操作符键就将目前的数据放入firstNum
            textBox.Text = "0"; //再将当前显示栏显示0
            Button btn = (Button)sender;
            if (btn.Equals(btnPlus))
                operator_str = "+";
            else if (btn.Equals(btnMinus))
                operator_str = "-";
            else if (btn.Equals(btnMult))
                operator_str = "*";
            else
                operator_str = "/";
        }


        private void btn_equal_click(object sender, EventArgs e)
        {
            int lastNum = Convert.ToInt32(textBox.Text);
            switch (operator_str)
            {
                case "+": textBox.Text = (firstNum + lastNum).ToString(); break;
                case "-": textBox.Text = (firstNum - lastNum).ToString(); break;
                case "*": textBox.Text = (firstNum * lastNum).ToString(); break;
                case "/": textBox.Text = (firstNum / lastNum).ToString(); break;
            }

        }

        private void btn_BackSpace_click(object sender, EventArgs e)
        {
            if (textBox.Text.Substring(0, textBox.Text.Length - 1) == "")
                textBox.Text = "0";
            else
            {
                textBox.Text = textBox.Text.Substring(0,textBox.Text.Length - 1);
            }
        }

        private void btn_AC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }


    }
}