namespace Calculator_homework2
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
            numBox1 = new TextBox();
            numBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_equal = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            rbtnPlus = new RadioButton();
            groupBox1 = new GroupBox();
            rbtnDivision = new RadioButton();
            rbtnMult = new RadioButton();
            rbtnMinus = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // numBox1
            // 
            numBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numBox1.Location = new Point(255, 35);
            numBox1.Name = "numBox1";
            numBox1.Size = new Size(279, 46);
            numBox1.TabIndex = 0;
            // 
            // numBox2
            // 
            numBox2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numBox2.Location = new Point(255, 117);
            numBox2.Name = "numBox2";
            numBox2.Size = new Size(279, 46);
            numBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 35);
            label1.Name = "label1";
            label1.Size = new Size(125, 39);
            label1.TabIndex = 3;
            label1.Text = "操作数1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 117);
            label2.Name = "label2";
            label2.Size = new Size(125, 39);
            label2.TabIndex = 4;
            label2.Text = "操作数2";
            // 
            // btn_equal
            // 
            btn_equal.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_equal.Location = new Point(637, 35);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(142, 128);
            btn_equal.TabIndex = 5;
            btn_equal.Text = "等于";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btnEqual_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(255, 207);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(279, 46);
            textBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 207);
            label3.Name = "label3";
            label3.Size = new Size(77, 39);
            label3.TabIndex = 7;
            label3.Text = "结果";
            // 
            // rbtnPlus
            // 
            rbtnPlus.AutoSize = true;
            rbtnPlus.Location = new Point(25, 43);
            rbtnPlus.Name = "rbtnPlus";
            rbtnPlus.Size = new Size(59, 39);
            rbtnPlus.TabIndex = 8;
            rbtnPlus.TabStop = true;
            rbtnPlus.Text = "+";
            rbtnPlus.UseVisualStyleBackColor = true;
            rbtnPlus.CheckedChanged += rbtn_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnDivision);
            groupBox1.Controls.Add(rbtnMult);
            groupBox1.Controls.Add(rbtnMinus);
            groupBox1.Controls.Add(rbtnPlus);
            groupBox1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(255, 284);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(279, 192);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "运算符";
            // 
            // rbtnDivision
            // 
            rbtnDivision.AutoSize = true;
            rbtnDivision.Location = new Point(176, 130);
            rbtnDivision.Name = "rbtnDivision";
            rbtnDivision.Size = new Size(51, 39);
            rbtnDivision.TabIndex = 11;
            rbtnDivision.TabStop = true;
            rbtnDivision.Text = "/";
            rbtnDivision.UseVisualStyleBackColor = true;
            rbtnDivision.CheckedChanged += rbtn_CheckedChanged;
            // 
            // rbtnMult
            // 
            rbtnMult.AutoSize = true;
            rbtnMult.Location = new Point(25, 130);
            rbtnMult.Name = "rbtnMult";
            rbtnMult.Size = new Size(52, 39);
            rbtnMult.TabIndex = 10;
            rbtnMult.TabStop = true;
            rbtnMult.Text = "*";
            rbtnMult.UseVisualStyleBackColor = true;
            rbtnMult.CheckedChanged += rbtn_CheckedChanged;
            // 
            // rbtnMinus
            // 
            rbtnMinus.AutoSize = true;
            rbtnMinus.Location = new Point(177, 43);
            rbtnMinus.Name = "rbtnMinus";
            rbtnMinus.Size = new Size(51, 39);
            rbtnMinus.TabIndex = 9;
            rbtnMinus.TabStop = true;
            rbtnMinus.Text = "-";
            rbtnMinus.UseVisualStyleBackColor = true;
            rbtnMinus.CheckedChanged += rbtn_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 515);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btn_equal);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numBox2);
            Controls.Add(numBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numBox1;
        private TextBox numBox2;
        private Label label1;
        private Label label2;
        private Button btn_equal;
        private TextBox textBox1;
        private Label label3;
        private RadioButton rbtnPlus;
        private GroupBox groupBox1;
        private RadioButton rbtnMinus;
        private RadioButton rbtnDivision;
        private RadioButton rbtnMult;
    }
}