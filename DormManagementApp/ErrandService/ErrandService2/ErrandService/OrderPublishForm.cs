using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeOutManagement
{
	public partial class OrderPublishForm : Form
	{		
		public Order CurrentOrder { get; set; }

		//添加订单的构造函数
		public OrderPublishForm()
		{
			CurrentOrder = new Order();
			InitializeComponent();
			orderBindingSource.DataSource = CurrentOrder;
		}
		//修改订单的构造函数
		public OrderPublishForm(Order order, bool editMode = false)
		{
			InitializeComponent();
			//TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
			CurrentOrder = order;
			orderBindingSource.DataSource = CurrentOrder;
			
		}

		private void btn_ConfirmPublish_Click(object sender, EventArgs e)
		{
			
			this.Close();
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
