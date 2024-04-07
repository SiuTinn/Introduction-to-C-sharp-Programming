namespace WindowsFormsOrderManage
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.radioButton_cname = new System.Windows.Forms.RadioButton();
            this.radioButton_amount = new System.Windows.Forms.RadioButton();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_addDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(0, 192);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 82;
            this.dataGridViewMain.RowTemplate.Height = 37;
            this.dataGridViewMain.Size = new System.Drawing.Size(1141, 355);
            this.dataGridViewMain.TabIndex = 0;
            this.dataGridViewMain.SelectionChanged += new System.EventHandler(this.dataGridViewMain_SelectionChanged);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(0, 575);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.RowHeadersWidth = 62;
            this.dataGridViewDetails.RowTemplate.Height = 37;
            this.dataGridViewDetails.Size = new System.Drawing.Size(1141, 165);
            this.dataGridViewDetails.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.AutoSize = true;
            this.button_Add.Location = new System.Drawing.Point(12, 0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(168, 69);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "添加订单";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_delete
            // 
            this.button_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_delete.Location = new System.Drawing.Point(575, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(138, 69);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "删除订单";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.radioButton_amount);
            this.groupBox.Controls.Add(this.radioButton_cname);
            this.groupBox.Controls.Add(this.radioButton_id);
            this.groupBox.Location = new System.Drawing.Point(741, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(361, 75);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "查找方式";
            // 
            // radioButton_id
            // 
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.Location = new System.Drawing.Point(16, 34);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(59, 28);
            this.radioButton_id.TabIndex = 0;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "Id";
            this.radioButton_id.UseVisualStyleBackColor = true;
            this.radioButton_id.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChange);
            // 
            // radioButton_cname
            // 
            this.radioButton_cname.AutoSize = true;
            this.radioButton_cname.Location = new System.Drawing.Point(92, 34);
            this.radioButton_cname.Name = "radioButton_cname";
            this.radioButton_cname.Size = new System.Drawing.Size(131, 28);
            this.radioButton_cname.TabIndex = 1;
            this.radioButton_cname.TabStop = true;
            this.radioButton_cname.Text = "Customer";
            this.radioButton_cname.UseVisualStyleBackColor = true;
            this.radioButton_cname.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChange);
            // 
            // radioButton_amount
            // 
            this.radioButton_amount.AutoSize = true;
            this.radioButton_amount.Location = new System.Drawing.Point(229, 34);
            this.radioButton_amount.Name = "radioButton_amount";
            this.radioButton_amount.Size = new System.Drawing.Size(107, 28);
            this.radioButton_amount.TabIndex = 2;
            this.radioButton_amount.TabStop = true;
            this.radioButton_amount.Text = "Amount";
            this.radioButton_amount.UseVisualStyleBackColor = true;
            this.radioButton_amount.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChange);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("宋体", 20F);
            this.textBox_search.Location = new System.Drawing.Point(12, 108);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(924, 53);
            this.textBox_search.TabIndex = 6;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(942, 108);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(160, 53);
            this.button_search.TabIndex = 7;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_Update
            // 
            this.button_Update.Cursor = System.Windows.Forms.Cursors.No;
            this.button_Update.Font = new System.Drawing.Font("宋体", 12F);
            this.button_Update.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Update.Location = new System.Drawing.Point(383, 0);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(168, 69);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "更新订单";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_addDetail
            // 
            this.button_addDetail.AutoSize = true;
            this.button_addDetail.Location = new System.Drawing.Point(193, 0);
            this.button_addDetail.Name = "button_addDetail";
            this.button_addDetail.Size = new System.Drawing.Size(168, 69);
            this.button_addDetail.TabIndex = 9;
            this.button_addDetail.Text = "添加细节";
            this.button_addDetail.UseVisualStyleBackColor = true;
            this.button_addDetail.Click += new System.EventHandler(this.button_addDetail_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 762);
            this.Controls.Add(this.button_addDetail);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.dataGridViewMain);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton radioButton_cname;
        private System.Windows.Forms.RadioButton radioButton_id;
        private System.Windows.Forms.RadioButton radioButton_amount;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_addDetail;
    }
}

