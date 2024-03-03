namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMult = new Button();
            btnDivision = new Button();
            btnEqual = new Button();
            btnAC = new Button();
            btnBS = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(108, 34);
            textBox.Name = "textBox";
            textBox.Size = new Size(880, 68);
            textBox.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(108, 149);
            btn7.Name = "btn7";
            btn7.Size = new Size(90, 76);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(248, 149);
            btn8.Name = "btn8";
            btn8.Size = new Size(90, 76);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(392, 149);
            btn9.Name = "btn9";
            btn9.Size = new Size(90, 76);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(108, 283);
            btn4.Name = "btn4";
            btn4.Size = new Size(90, 76);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(248, 283);
            btn5.Name = "btn5";
            btn5.Size = new Size(90, 76);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(392, 283);
            btn6.Name = "btn6";
            btn6.Size = new Size(90, 76);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(108, 421);
            btn1.Name = "btn1";
            btn1.Size = new Size(90, 76);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(248, 421);
            btn2.Name = "btn2";
            btn2.Size = new Size(90, 76);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(392, 421);
            btn3.Name = "btn3";
            btn3.Size = new Size(90, 76);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(108, 561);
            btn0.Name = "btn0";
            btn0.Size = new Size(230, 76);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.Location = new Point(608, 283);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(150, 76);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btn_operator_click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.Location = new Point(838, 271);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(150, 76);
            btnMinus.TabIndex = 12;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btn_operator_click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMult.Location = new Point(608, 421);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(150, 76);
            btnMult.TabIndex = 13;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btn_operator_click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivision.Location = new Point(838, 421);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(150, 76);
            btnDivision.TabIndex = 14;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btn_operator_click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(608, 561);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(150, 76);
            btnEqual.TabIndex = 15;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btn_equal_click;
            // 
            // btnAC
            // 
            btnAC.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAC.Location = new Point(608, 149);
            btnAC.Name = "btnAC";
            btnAC.Size = new Size(150, 76);
            btnAC.TabIndex = 16;
            btnAC.Text = "AC";
            btnAC.UseVisualStyleBackColor = true;
            btnAC.Click += btn_AC_Click;
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBS.Location = new Point(838, 149);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(150, 76);
            btnBS.TabIndex = 17;
            btnBS.Text = "BackSpace";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btn_BackSpace_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 712);
            Controls.Add(btnBS);
            Controls.Add(btnAC);
            Controls.Add(btnEqual);
            Controls.Add(btnDivision);
            Controls.Add(btnMult);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn0;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMult;
        private Button btnDivision;
        private Button btnEqual;
        private Button btnAC;
        private Button btnBS;
    }
}