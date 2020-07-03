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
	public partial class HistoryOrder : Form
	{
		public OrderOperation orderOperation;
		private string input;
		public string Input { get => input; set => input = value; }


		public HistoryOrder(OrderOperation op)
		{
			InitializeComponent();
			User user1 = new User("Celia", 2018302541, 1365477586);
			Order order1 = new Order(user1, 50, DateTime.Today, "打印论文");
			List<Order> orderlist = new List<Order> { order1 };
			//orderOperation = new OrderOperation(orderlist);
			orderOperation = op;
			orderDataBinding1.DataSource = orderOperation.OrderList;
			txt_item.DataBindings.Add("Text", this, "Input");


		}

		private void btn_Modify_Click(object sender, EventArgs e)
		{
			Order order = orderDataBinding1.Current as Order;
			if (order == null)
			{
				MessageBox.Show("请选择一个订单进行修改");
				return;
			}

			else if (order.IsPublisher == false || order.OrderState == Order.State.Fulfilled)
			{
				MessageBox.Show("订单无法修改");
				return;
			}

			OrderPublishForm form = new OrderPublishForm(order, true);
			if (form.ShowDialog() == DialogResult.OK)
			{
				orderOperation.OrderModify(form.CurrentOrder);
				QueryAll();
			}
		}


		private void QueryAll()
		{
			orderDataBinding1.DataSource = orderOperation.OrderList;
			orderDataBinding1.ResetBindings(false);
		}

		private void btn_Quary_Click(object sender, EventArgs e)
		{
			switch (cbx_item.SelectedIndex)
			{
				case 0:
					orderDataBinding1.DataSource = orderOperation.OrderList;
					break;
				case 1:
					orderDataBinding1.DataSource = orderOperation.OrderQuery(OrderOperation.Attribute.isPublisher, "1");
					break;
				case 2:
					orderDataBinding1.DataSource = orderOperation.OrderQuery(OrderOperation.Attribute.OrderState, Input);
					break;
				case 3:
					orderDataBinding1.DataSource = orderOperation.OrderQuery(OrderOperation.Attribute.Price, Input);
					break;
				case 4:
					orderDataBinding1.DataSource = orderOperation.OrderQuery(OrderOperation.Attribute.CreateTime, Input);
					break;
				case 5:
					orderDataBinding1.DataSource = orderOperation.OrderQuery(OrderOperation.Attribute.UserName, Input);
					break;


				default:
					orderDataBinding1.DataSource = orderOperation.OrderList;
					break;
			}
			orderDataBinding1.ResetBindings(true);
		}

		private void btn_del_Click(object sender, EventArgs e)
		{
			Order order = orderDataBinding1.Current as Order;
			if (order == null)
			{
				MessageBox.Show("未选中任何订单！");
				return;
			}
			orderOperation.OrderDel(order.OrderID);
			QueryAll();
			MessageBox.Show("删除成功！");

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Order order = orderDataBinding1.Current as Order;
			
			if (order == null)
			{
				MessageBox.Show("未选中任何订单");
				return;
			}
			new ShowDetail(order).Show();
			//ShowDetail showDetail = new ShowDetail(order);
			//if (showDetail.ShowDialog() == DialogResult.OK)
			//{
			//	orderOperation.OrderModify(showDetail.CurrentOrder);
			//	QueryAll();
			//}
		}

		
		
		
	}	

}
