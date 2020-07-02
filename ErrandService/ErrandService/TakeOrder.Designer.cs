namespace DormManagementApp
{
	partial class TakeOrder
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
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.demandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timeLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.endPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDataBinding = new System.Windows.Forms.BindingSource(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_TakeOrder = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbx_start = new System.Windows.Forms.ComboBox();
			this.btn_Quary = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbx_end = new System.Windows.Forms.ComboBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_publish = new System.Windows.Forms.Button();
			this.btn_historyorder = new System.Windows.Forms.Button();
			this.btn_notice = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(138, 518);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.createTimeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.demandDataGridViewTextBoxColumn,
            this.timeLimitDataGridViewTextBoxColumn,
            this.startPointDataGridViewTextBoxColumn,
            this.endPointDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderDataBinding;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(10, 10);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(881, 383);
			this.dataGridView1.TabIndex = 1;
			// 
			// createTimeDataGridViewTextBoxColumn
			// 
			this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
			this.createTimeDataGridViewTextBoxColumn.HeaderText = "CreateTime";
			this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
			this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// demandDataGridViewTextBoxColumn
			// 
			this.demandDataGridViewTextBoxColumn.DataPropertyName = "Demand";
			this.demandDataGridViewTextBoxColumn.HeaderText = "Demand";
			this.demandDataGridViewTextBoxColumn.Name = "demandDataGridViewTextBoxColumn";
			this.demandDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// timeLimitDataGridViewTextBoxColumn
			// 
			this.timeLimitDataGridViewTextBoxColumn.DataPropertyName = "TimeLimit";
			this.timeLimitDataGridViewTextBoxColumn.HeaderText = "TimeLimit";
			this.timeLimitDataGridViewTextBoxColumn.Name = "timeLimitDataGridViewTextBoxColumn";
			this.timeLimitDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// startPointDataGridViewTextBoxColumn
			// 
			this.startPointDataGridViewTextBoxColumn.DataPropertyName = "StartPoint";
			this.startPointDataGridViewTextBoxColumn.HeaderText = "StartPoint";
			this.startPointDataGridViewTextBoxColumn.Name = "startPointDataGridViewTextBoxColumn";
			this.startPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// endPointDataGridViewTextBoxColumn
			// 
			this.endPointDataGridViewTextBoxColumn.DataPropertyName = "EndPoint";
			this.endPointDataGridViewTextBoxColumn.HeaderText = "EndPoint";
			this.endPointDataGridViewTextBoxColumn.Name = "endPointDataGridViewTextBoxColumn";
			this.endPointDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderDataBinding
			// 
			this.orderDataBinding.DataSource = typeof(DormManagementApp.Order);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dataGridView1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(138, 52);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(10);
			this.panel2.Size = new System.Drawing.Size(901, 403);
			this.panel2.TabIndex = 9;
			// 
			// btn_TakeOrder
			// 
			this.btn_TakeOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TakeOrder.Location = new System.Drawing.Point(778, 15);
			this.btn_TakeOrder.Name = "btn_TakeOrder";
			this.btn_TakeOrder.Size = new System.Drawing.Size(112, 30);
			this.btn_TakeOrder.TabIndex = 0;
			this.btn_TakeOrder.Text = "接单";
			this.btn_TakeOrder.UseVisualStyleBackColor = true;
			this.btn_TakeOrder.Click += new System.EventHandler(this.btn_TakeOrder_Click_1);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_TakeOrder);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(138, 455);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(901, 63);
			this.panel1.TabIndex = 8;
			// 
			// cbx_start
			// 
			this.cbx_start.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cbx_start.FormattingEnabled = true;
			this.cbx_start.Items.AddRange(new object[] {
            "位置不限",
            "文理学部",
            "信息学部",
            "工学部",
            "医学部"});
			this.cbx_start.Location = new System.Drawing.Point(86, 13);
			this.cbx_start.Name = "cbx_start";
			this.cbx_start.Size = new System.Drawing.Size(129, 23);
			this.cbx_start.TabIndex = 3;
			// 
			// btn_Quary
			// 
			this.btn_Quary.Location = new System.Drawing.Point(356, 13);
			this.btn_Quary.Name = "btn_Quary";
			this.btn_Quary.Size = new System.Drawing.Size(75, 25);
			this.btn_Quary.TabIndex = 2;
			this.btn_Quary.Text = "查询";
			this.btn_Quary.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.cbx_start);
			this.flowLayoutPanel1.Controls.Add(this.cbx_end);
			this.flowLayoutPanel1.Controls.Add(this.btn_Quary);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(901, 52);
			this.flowLayoutPanel1.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "起止地点";
			// 
			// cbx_end
			// 
			this.cbx_end.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.cbx_end.FormattingEnabled = true;
			this.cbx_end.Items.AddRange(new object[] {
            "位置不限",
            "文理学部",
            "信息学部",
            "工学部",
            "医学部"});
			this.cbx_end.Location = new System.Drawing.Point(221, 13);
			this.cbx_end.Name = "cbx_end";
			this.cbx_end.Size = new System.Drawing.Size(129, 23);
			this.cbx_end.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btn_publish, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_historyorder, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_notice, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(138, 186);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// btn_publish
			// 
			this.btn_publish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_publish.Location = new System.Drawing.Point(10, 20);
			this.btn_publish.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.btn_publish.Name = "btn_publish";
			this.btn_publish.Size = new System.Drawing.Size(118, 35);
			this.btn_publish.TabIndex = 0;
			this.btn_publish.Text = "发布跑腿订单";
			this.btn_publish.UseVisualStyleBackColor = true;
			this.btn_publish.Click += new System.EventHandler(this.btn_publish_Click);
			// 
			// btn_historyorder
			// 
			this.btn_historyorder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_historyorder.Location = new System.Drawing.Point(10, 130);
			this.btn_historyorder.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.btn_historyorder.Name = "btn_historyorder";
			this.btn_historyorder.Size = new System.Drawing.Size(118, 36);
			this.btn_historyorder.TabIndex = 2;
			this.btn_historyorder.Text = "我的订单";
			this.btn_historyorder.UseVisualStyleBackColor = true;
			this.btn_historyorder.Click += new System.EventHandler(this.btn_historyorder_Click);
			// 
			// btn_notice
			// 
			this.btn_notice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_notice.Location = new System.Drawing.Point(10, 75);
			this.btn_notice.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.btn_notice.Name = "btn_notice";
			this.btn_notice.Size = new System.Drawing.Size(118, 35);
			this.btn_notice.TabIndex = 3;
			this.btn_notice.Text = "消息通知";
			this.btn_notice.UseVisualStyleBackColor = true;
			this.btn_notice.Click += new System.EventHandler(this.btn_notice_Click);
			// 
			// TakeOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1039, 518);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.splitter1);
			this.Name = "TakeOrder";
			this.Text = "接单";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn demandDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timeLimitDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn endPointDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource orderDataBinding;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_TakeOrder;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cbx_start;
		private System.Windows.Forms.Button btn_Quary;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbx_end;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btn_publish;
		private System.Windows.Forms.Button btn_historyorder;
		private System.Windows.Forms.Button btn_notice;
	}
}