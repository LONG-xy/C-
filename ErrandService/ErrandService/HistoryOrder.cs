using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace DormManagementApp
{
	public partial class HistoryOrder : Form
	{
		public OrderOperation orderOperation;
		private string input;
		public string Input { get => input; set => input = value; }


		public HistoryOrder(OrderOperation op)
		{
			InitializeComponent();
			Uri uri = new Uri("http://localhost:64632/api/TakeOut/GetOrderTable");
			//WebClient:获取webapi中的数据。
			using (WebClient c = new WebClient())
			{
				//c.Headers["Type"]:获取数据的方式
				c.Headers["Type"] = "GET";
				//c.Headers["Accept"]:获取数据的格式
				c.Headers["Accept"] = "application/json";
				//c.Encoding：数据的编码格式。
				c.Encoding = Encoding.UTF8;
				//DownloadDataCompleted:在多线程情况下，能进行webApi数据传输。
				c.DownloadStringCompleted += (senderobj, es) =>
				{
					if (es.Result != null)
					{
						//把webApi之中获取的json数据 序列化成dataTable
						var test = JsonConvert.DeserializeObject<DataTable>(es.Result);
						//GV绑定dataTable数据
						orderDataBinding1.DataSource = test;
					}
				};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);

			}
			//	User user1 = new User("Celia", 2018302541, 1365477586);
			//Order order1 = new Order(user1, 50, DateTime.Today, "打印论文");
			//List<Order> orderlist = new List<Order> { order1 };
			////orderOperation = new OrderOperation(orderlist);
			//orderOperation = op;
			//orderDataBinding1.DataSource = orderOperation.OrderList;
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
				//orderOperation.OrderModify(form.CurrentOrder);
				Uri uri = new Uri("http://localhost:64632/api/ErrandService/UpdateOrder?Order = " + form.CurrentOrder);

				using (WebClient c = new WebClient())
				{
					//c.Headers["Type"]:获取数据的方式
					c.Headers["Type"] = "Get";
					//c.Headers["Accept"]:获取数据的格式
					c.Headers["Accept"] = "application/json";
					//c.Encoding：数据的编码格式。
					c.Encoding = Encoding.UTF8;
					//DownloadDataCompleted:在多线程情况下，能进行webApi数据传输。
					c.DownloadStringCompleted += (senderobj, es) =>
					{
						//es.Result:如果获取的webapi之中的数据不为空，则绑定gv
						if (es.Result != null)
						{
							if (es.Result == "\"OK\"")
							{
								MessageBox.Show("修改成功！");
							}
							else
							{
								MessageBox.Show("修改失败");
							}
						}
						QueryAll();
					};
					//把当前webApi地址释放掉。
					c.DownloadStringAsync(uri);
				}
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
			//orderOperation.OrderDel(order.OrderID);
			//QueryAll();
			//MessageBox.Show("删除成功！");


			Uri uri = new Uri("http://localhost:64632/api/ErrandService/DeleteOrder?OrderID = " + order.OrderID);

			using (WebClient c = new WebClient())
			{
				//c.Headers["Type"]:获取数据的方式
				c.Headers["Type"] = "Get";
				//c.Headers["Accept"]:获取数据的格式
				c.Headers["Accept"] = "application/json";
				//c.Encoding：数据的编码格式。
				c.Encoding = Encoding.UTF8;
				//DownloadDataCompleted:在多线程情况下，能进行webApi数据传输。
				c.DownloadStringCompleted += (senderobj, es) =>
				{
					//es.Result:如果获取的webapi之中的数据不为空，则绑定gv
					if (es.Result != null)
					{
						if (es.Result == "\"OK\"")
						{
							MessageBox.Show("删除成功");
						}
						else
						{
							MessageBox.Show("删除失败");
						}
					}
					QueryAll();
				};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);
			}

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
