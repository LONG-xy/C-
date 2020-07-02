using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace DormManagementApp
{
	public partial class TakeOrder : Form
	{
		public OrderOperation orderTakerService;
		public OrderOperation orderOperation;
		
		public TakeOrder()
		{
			InitializeComponent();

			Uri uri = new Uri("http://localhost:64632/api/TakeOut/GetPublicOrderTable");
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
		orderDataBinding.DataSource = test;
	}
};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);
			}

			//User user = new User("li", 55, 13);
			//Order order = new Order(user, 5, DateTime.Today, "wu");
			//List<Order> orderlist = new List<Order> { order };
			//orderOperation = new OrderOperation(orderlist);
			//orderDataBinding.DataSource = orderOperation.OrderList;
			//orderTakerService = new OrderOperation();
			////orderDataBinding.DataSource = orderOperation.OrderList;

		}

		private void btn_TakeOrder_Click(object sender, EventArgs e)

		{
			Order order = orderDataBinding.Current as Order;
			if (order == null)
			{
				MessageBox.Show("未选择任何订单！");
				return;
			}
			//修改订单状态
			order.StateChangeToTaken();
			order.IsPublisher = false;

			Uri uri = new Uri("http://localhost:64632/api/ErrandService/AddOrder?Order=" + order);

			//WebClient:获取webaapi中的数据。
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
					//es.Result:如果获取的webapi之中的数据不为空，则绑定gv
					if (es.Result != null)
					{
						if (es.Result == "\"OK\"")
						{
							MessageBox.Show("已接单，请前往历史订单查看");

						}
						else
						{
							MessageBox.Show("接单失败");
						}
					}
				};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);
			}


			//orderTakerService.OrderAdd(order);
			//order.StateChangeToTaken();
			//order.IsPublisher = false;
			//MessageBox.Show("已接单，请前往历史订单查看");
		}

	



		private void btn_Quary_Click(object sender, EventArgs e)
		{
			//orderDataBinding.DataSource = orderOperation.OrderQuery(cbx_start.Text, cbx_end.Text);
			//Uri uri = new Uri("http://localhost:64632/api/TakeOut/GetPublicOrderTable");
			////WebClient:获取webapi中的数据。
			//using (WebClient c = new WebClient())
			//{
			//	//c.Headers["Type"]:获取数据的方式
			//	c.Headers["Type"] = "GET";
			//	//c.Headers["Accept"]:获取数据的格式
			//	c.Headers["Accept"] = "application/json";
			//	//c.Encoding：数据的编码格式。
			//	c.Encoding = Encoding.UTF8;
			//	//DownloadDataCompleted:在多线程情况下，能进行webApi数据传输。
			//	c.DownloadStringCompleted += (senderobj, es) =>
			//	{
			//		if (es.Result != null)
			//		{
			//			//把webApi之中获取的json数据 序列化成dataTable
			//			var test = JsonConvert.DeserializeObject<DataTable>(es.Result);
			//			//GV绑定dataTable数据
			//			orderDataBinding.DataSource = test;
			//		}
			//	};
			//	//把当前webApi地址释放掉。
			//	c.DownloadStringAsync(uri);
			//}

			//orderDataBinding.ResetBindings(true);
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
				//orderTakerService.OrderAdd(orderPublishForm.CurrentOrder);
				Order order = orderPublishForm.CurrentOrder;
				Uri uri = new Uri("http://localhost:64632/api/ErrandService/AddOrder?Order=" + order);

				//WebClient:获取webaapi中的数据。
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
						//es.Result:如果获取的webapi之中的数据不为空，则绑定gv
						if (es.Result != null)
						{
							if (es.Result == "\"OK\"")
							{
								MessageBox.Show("订单发布成功！");

							}
							else
							{
								MessageBox.Show("发布失败");
							}
						}
					};
					//把当前webApi地址释放掉。
					c.DownloadStringAsync(uri);
				}

				Uri uri1 = new Uri("http://localhost:64632/api/ErrandService/AddPublicOrder?Order=" + order);

				//WebClient:获取webaapi中的数据。
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
						
					};
					//把当前webApi地址释放掉。
					c.DownloadStringAsync(uri1);
				}
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
			//修改订单状态
			order.StateChangeToTaken();
			order.IsPublisher = false;

			Uri uri = new Uri("http://localhost:64632/api/ErrandService/AddOrder?Order=" + order);

			//WebClient:获取webaapi中的数据。
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
					//es.Result:如果获取的webapi之中的数据不为空，则绑定gv
					if (es.Result != null)
					{
						if (es.Result == "\"OK\"")
						{
							MessageBox.Show("已接单，请前往历史订单查看");

						}
						else
						{
							MessageBox.Show("接单失败");
						}
					}
				};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);
			}


			//orderTakerService.OrderAdd(order);
			//order.StateChangeToTaken();
			//order.IsPublisher = false;
			//MessageBox.Show("已接单，请前往历史订单查看");
		}
	}
}
