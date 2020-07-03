namespace ErrandService
{
    partial class ShowDetail
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
            this.cbx_item = new System.Windows.Forms.ComboBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.btn_Quary = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_item
            // 
            this.cbx_item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbx_item.FormattingEnabled = true;
            this.cbx_item.Items.AddRange(new object[] {
            "全部跑腿订单",
            "我发布的跑腿订单",
            "订单状态",
            "金额大于",
            "创建时间",
            "用户名"});
            this.cbx_item.Location = new System.Drawing.Point(7, 11);
            this.cbx_item.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_item.Name = "cbx_item";
            this.cbx_item.Size = new System.Drawing.Size(98, 20);
            this.cbx_item.TabIndex = 6;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(109, 11);
            this.txt_item.Margin = new System.Windows.Forms.Padding(2);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(96, 21);
            this.txt_item.TabIndex = 4;
            // 
            // btn_Quary
            // 
            this.btn_Quary.Location = new System.Drawing.Point(209, 11);
            this.btn_Quary.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Quary.Name = "btn_Quary";
            this.btn_Quary.Size = new System.Drawing.Size(56, 20);
            this.btn_Quary.TabIndex = 5;
            this.btn_Quary.Text = "查询";
            this.btn_Quary.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(7, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(949, 391);
            this.dataGridView1.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(673, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 24);
            this.button4.TabIndex = 10;
            this.button4.Text = "查看详情";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(772, 9);
            this.btn_Modify.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(84, 24);
            this.btn_Modify.TabIndex = 9;
            this.btn_Modify.Text = "修改订单";
            this.btn_Modify.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(872, 9);
            this.btn_del.Margin = new System.Windows.Forms.Padding(2);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(84, 24);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "删除记录";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "订单号";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "创建时间";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "金额";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "要求";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "时间限制";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "订单状态";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "起始地点";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "结束地点";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "我发布的";
            this.Column4.Name = "Column4";
            // 
            // HistoryOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_item);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.btn_Quary);
            this.Name = "HistoryOrderForm";
            this.Text = "历史订单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_item;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Button btn_Quary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Modify;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}