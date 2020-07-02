namespace TakeOutManagement
{
	partial class HistoryOrder
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.btn_Modify = new System.Windows.Forms.Button();
			this.btn_del = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isPublisherDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.timeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDataBinding1 = new System.Windows.Forms.BindingSource(this.components);
			this.btn_Quary = new System.Windows.Forms.Button();
			this.txt_item = new System.Windows.Forms.TextBox();
			this.cbx_item = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding1)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.btn_Modify);
			this.panel1.Controls.Add(this.btn_del);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 443);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(978, 62);
			this.panel1.TabIndex = 2;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(580, 21);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 30);
			this.button4.TabIndex = 2;
			this.button4.Text = "查看详情";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btn_Modify
			// 
			this.btn_Modify.Location = new System.Drawing.Point(712, 21);
			this.btn_Modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Modify.Name = "btn_Modify";
			this.btn_Modify.Size = new System.Drawing.Size(112, 30);
			this.btn_Modify.TabIndex = 1;
			this.btn_Modify.Text = "修改订单";
			this.btn_Modify.UseVisualStyleBackColor = true;
			this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
			// 
			// btn_del
			// 
			this.btn_del.Location = new System.Drawing.Point(845, 21);
			this.btn_del.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_del.Name = "btn_del";
			this.btn_del.Size = new System.Drawing.Size(112, 30);
			this.btn_del.TabIndex = 0;
			this.btn_del.Text = "删除记录";
			this.btn_del.UseVisualStyleBackColor = true;
			this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 52);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
			this.panel2.Size = new System.Drawing.Size(978, 391);
			this.panel2.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.isPublisherDataGridViewCheckBoxColumn,
            this.timeLimitDataGridViewTextBoxColumn,
            this.orderStateDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderDataBinding1;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(11, 10);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(956, 371);
			this.dataGridView1.TabIndex = 1;
			// 
			// createTimeDataGridViewTextBoxColumn
			// 
			this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
			this.createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
			this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
			this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "金额";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// demandDataGridViewTextBoxColumn
			// 
			this.demandDataGridViewTextBoxColumn.DataPropertyName = "Demand";
			this.demandDataGridViewTextBoxColumn.HeaderText = "要求";
			this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
			this.demandDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// isPublisherDataGridViewCheckBoxColumn
			// 
			this.isPublisherDataGridViewCheckBoxColumn.DataPropertyName = "IsPublisher";
			this.isPublisherDataGridViewCheckBoxColumn.HeaderText = "我发布的";
			this.isPublisherDataGridViewCheckBoxColumn.Name = "isPublisherDataGridViewCheckBoxColumn";
			this.isPublisherDataGridViewCheckBoxColumn.ReadOnly = true;
			// 
			// timeLimitDataGridViewTextBoxColumn
			// 
			this.timeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
			this.timeLimitDataGridViewTextBoxColumn.HeaderText = "时间限制";
			this.timeLimitDataGridViewTextBoxColumn.Name = "timeLimitDataGridViewTextBoxColumn";
			this.timeLimitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderStateDataGridViewTextBoxColumn
			// 
			this.orderStateDataGridViewTextBoxColumn.DataPropertyName = "OrderState";
			this.orderStateDataGridViewTextBoxColumn.HeaderText = "订单状态";
			this.orderStateDataGridViewTextBoxColumn.Name = "orderStateDataGridViewTextBoxColumn";
			this.orderStateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// startPointDataGridViewTextBoxColumn
			// 
			this.startPointDataGridViewTextBoxColumn.DataPropertyName = "StartPoint";
			this.startPointDataGridViewTextBoxColumn.HeaderText = "起始地点";
			this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
			this.startPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endPointDataGridViewTextBoxColumn
			// 
			this.endPointDataGridViewTextBoxColumn.DataPropertyName = "EndPoint";
			this.endPointDataGridViewTextBoxColumn.HeaderText = "结束地点";
			this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
			this.endPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderDataBinding1
			// 
			this.orderDataBinding1.DataSource = typeof(TakeOutManagement.Order);
			// 
			// btn_Quary
			// 
			this.btn_Quary.Location = new System.Drawing.Point(282, 12);
			this.btn_Quary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Quary.Name = "btn_Quary";
			this.btn_Quary.Size = new System.Drawing.Size(75, 25);
			this.btn_Quary.TabIndex = 2;
			this.btn_Quary.Text = "查询";
			this.btn_Quary.UseVisualStyleBackColor = true;
			this.btn_Quary.Click += new System.EventHandler(this.btn_Quary_Click);
			// 
			// txt_item
			// 
			this.txt_item.Location = new System.Drawing.Point(149, 12);
			this.txt_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_item.Name = "txt_item";
			this.txt_item.Size = new System.Drawing.Size(127, 25);
			this.txt_item.TabIndex = 1;
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
			this.cbx_item.Location = new System.Drawing.Point(14, 12);
			this.cbx_item.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbx_item.Name = "cbx_item";
			this.cbx_item.Size = new System.Drawing.Size(129, 23);
			this.cbx_item.TabIndex = 3;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.cbx_item);
			this.flowLayoutPanel1.Controls.Add(this.txt_item);
			this.flowLayoutPanel1.Controls.Add(this.btn_Quary);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(978, 52);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// HistoryOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 505);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "HistoryOrder";
			this.Text = "我的订单";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding1)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource orderDataBinding1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Modify;
		private System.Windows.Forms.Button btn_del;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isPublisherDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderStateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Quary;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.ComboBox cbx_item;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}