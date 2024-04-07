namespace WindowsFormsOrderManage
{
    partial class UpdataForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_newCname = new System.Windows.Forms.TextBox();
            this.button_update_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "新顾客名";
            // 
            // textBox_newCname
            // 
            this.textBox_newCname.Location = new System.Drawing.Point(240, 113);
            this.textBox_newCname.Name = "textBox_newCname";
            this.textBox_newCname.Size = new System.Drawing.Size(334, 35);
            this.textBox_newCname.TabIndex = 3;
            // 
            // button_update_2
            // 
            this.button_update_2.Location = new System.Drawing.Point(240, 271);
            this.button_update_2.Name = "button_update_2";
            this.button_update_2.Size = new System.Drawing.Size(334, 44);
            this.button_update_2.TabIndex = 4;
            this.button_update_2.Text = "更新订单";
            this.button_update_2.UseVisualStyleBackColor = true;
            this.button_update_2.Click += new System.EventHandler(this.button_update_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "请注意，该订单的细节将会清空，请重新添加订单细节";
            // 
            // UpdataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_update_2);
            this.Controls.Add(this.textBox_newCname);
            this.Controls.Add(this.label2);
            this.Name = "UpdataForm";
            this.Text = "更新订单";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_newCname;
        private System.Windows.Forms.Button button_update_2;
        private System.Windows.Forms.Label label1;
    }
}