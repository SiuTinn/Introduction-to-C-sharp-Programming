namespace WindowsFormsOrderManage
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.button_add_2 = new System.Windows.Forms.Button();
            this.textBox_cname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Id
            // 
            this.textBox_Id.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_Id.Location = new System.Drawing.Point(45, 66);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(410, 53);
            this.textBox_Id.TabIndex = 0;
            this.textBox_Id.Text = "ID";
            // 
            // button_add_2
            // 
            this.button_add_2.Location = new System.Drawing.Point(45, 330);
            this.button_add_2.Name = "button_add_2";
            this.button_add_2.Size = new System.Drawing.Size(129, 53);
            this.button_add_2.TabIndex = 1;
            this.button_add_2.Text = "Add";
            this.button_add_2.UseVisualStyleBackColor = true;
            this.button_add_2.Click += new System.EventHandler(this.button_add_2_Click);
            // 
            // textBox_cname
            // 
            this.textBox_cname.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_cname.Location = new System.Drawing.Point(45, 206);
            this.textBox_cname.Name = "textBox_cname";
            this.textBox_cname.Size = new System.Drawing.Size(410, 53);
            this.textBox_cname.TabIndex = 2;
            this.textBox_cname.Text = "Customer Name";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.textBox_cname);
            this.Controls.Add(this.button_add_2);
            this.Controls.Add(this.textBox_Id);
            this.Name = "AddForm";
            this.Text = "添加订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Button button_add_2;
        private System.Windows.Forms.TextBox textBox_cname;
    }
}