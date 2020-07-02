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
	public partial class TakeOrder : Form
	{
		public OrderOperation orderTakerService;
		public OrderOperation orderOperation;
		
		public TakeOrder()
		{
			InitializeComponent();
			User user = new User("li", 55, 13);
			Order order = new Order(user, 5, DateTime.Today, "帮忙打印");
			List<Order> orderlist = new List<Order> { order };
			orderOperation = new OrderOperation(orderlist);
			orderDataBinding.DataSource = orderOperation.OrderList;
			orderTakerService = new OrderOperation();
			//orderDataBinding.DataSource = orderOperation.OrderList;

		}

		private void btn_TakeOrder_Click(object sender, EventArgs e)

		{
			Order order = orderDataBinding.Current as Order;
			if (order == null)
			{
				MessageBox.Show("未选择任何订单！");
				return;
			}
			orderTakerService.OrderAdd(order);
			order.StateChangeToTaken();
			order.IsPublisher = false;
			MessageBox.Show("已接单，请前往历史订单查看");
		}

	



		private void btn_Quary_Click(object sender, EventArgs e)
		{
			orderDataBinding.DataSource = orderOperation.OrderQuery(cbx_start.Text, cbx_end.Text);
			orderDataBinding.ResetBindings(true);
		}

		private void QueryAll()
		{
			orderDataBinding.DataSource = orderOperation.OrderList;
			orderDataBinding.ResetBindings(false);
		}

		private void btn_publish_Click(object sender, EventArgs e)
		{
			OrderPublishForm orderPublishForm = new OrderPublishForm();
			if (orderPublishForm.ShowDialog() == DialogResult.OK)
			{
				orderTakerService.OrderAdd(orderPublishForm.CurrentOrder);
				MessageBox.Show("订单发布成功！");
			}
		}

		private void btn_notice_Click(object sender, EventArgs e)
		{
			new FClient().Show();
		}

		private void btn_historyorder_Click(object sender, EventArgs e)
		{
			new HistoryOrder(orderTakerService).Show();
		}

		private void btn_TakeOrder_Click_1(object sender, EventArgs e)
		{
			Order order = orderDataBinding.Current as Order;
			if (order == null)
			{
				MessageBox.Show("未选择任何订单！");
				return;
			}
			orderTakerService.OrderAdd(order);
			order.StateChangeToTaken();
			order.IsPublisher = false;
			MessageBox.Show("已接单，请前往历史订单查看");
		}
	}
}
