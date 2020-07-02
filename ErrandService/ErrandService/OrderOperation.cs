using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace DormManagementApp
{
	public class OrderOperation
	{

		List<Order> orderList;
		public List<Order> OrderList { get => orderList; set => orderList = value; }

		//构造函数
		public OrderOperation() { orderList = new List<Order>(); }
		public OrderOperation(List<Order> OL) { orderList = OL; }



		public enum Attribute { UserName, Price, isPublisher, OrderState, CreateTime }
		public List<Order> OrderQuery(string start = "", string end = "")
		{
			IEnumerable<Order> result = null;

			if (start == "位置不限" && end == "位置不限") return OrderList;
			else if (start == "位置不限")
			{
				result = from o in OrderList
						 where o.EndPoint.ToString() == end
						 orderby o.CreateTime
						 select o;
			}
			else if (end == "位置不限")
			{
				result = from o in OrderList
						 where o.StartPoint.ToString() == start
						 orderby o.CreateTime
						 select o;
			}
			else
			{
				result = from o in OrderList
						 where o.StartPoint.ToString() == start && o.EndPoint.ToString() == end
						 orderby o.CreateTime
						 select o;
			}

			List<Order> asList = result.ToList();
			return asList;
		}

		public List<Order> OrderQuery(Attribute type, string item = "")  //按OrderNumber
		{
			IEnumerable<Order> result = null;
			switch (type)
			{
				case Attribute.UserName:
					result = from o in OrderList
							 where o.User.UserName == item
							 orderby o.CreateTime
							 select o;
					break;

				case Attribute.OrderState:
					result = from o in OrderList
							 where o.OrderState.ToString() == item
							 orderby o.CreateTime
							 select o;
					break;

				case Attribute.isPublisher:
					result = from o in OrderList
							 where o.IsPublisher == true
							 orderby o.CreateTime
							 select o;
					break;

				case Attribute.Price:
					result = from o in OrderList
							 where o.Price >= double.Parse(item)
							 orderby o.CreateTime
							 select o;
					break;
				case Attribute.CreateTime:
					result = from o in OrderList
							 where o.CreateTime >= Convert.ToDateTime(item)
							 orderby o.CreateTime
							 select o;
					break;
			}
			List<Order> asList = result.ToList();
			return asList;

		}

		public Order GetOrder(uint id)
		{
			return orderList.Where(o => o.OrderID == id).FirstOrDefault();
		}


		//添加
		public void OrderAdd(Order newOrder)
		{

			if (OrderList.Contains(newOrder))
				throw new ApplicationException($"Add Order Error: Order with id {newOrder.OrderID} already exists!");
			if (newOrder == null)
				throw new ApplicationException($"Add Order Error: Order is null");

			//orderList.Add(newOrder);
			Uri uri = new Uri("http://localhost:64632/api/ErrandService/AddOrder?Order=" + newOrder);

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
							MessageBox.Show("订单添加成功！");

						}
						else
						{
							MessageBox.Show("订单添加失败");
						}
					}
				};
				//把当前webApi地址释放掉。
				c.DownloadStringAsync(uri);
			}
			//MessageBox.Show("订单发布成功！");
		}

		public void OrderModify(Order newOrder)//修改 价格，需求，时间限制
		{
			Order oldOrder = GetOrder(newOrder.OrderID);
			if (oldOrder == null)
				throw new ApplicationException($"Update Error：the order with id {newOrder.OrderID} does not exist!");
			OrderList.Remove(oldOrder);
			OrderList.Add(newOrder);
		}

		//public void StateChangeToTaken(Order takenOrder)
		//{
		//	if (takenOrder.OrderState == Order.State.Published)
		//		takenOrder.OrderState = Order.State.Taken;
		//	else if (takenOrder.OrderState == Order.State.Taken)
		//		takenOrder.OrderState = Order.State.Fulfilled;
		//	else
		//		throw new ApplicationException($"State Change Error：the order's state can't be changed!");

		//}

		public void OrderDel(uint OrderID)
		{
			
		}



	}
	
	



}
