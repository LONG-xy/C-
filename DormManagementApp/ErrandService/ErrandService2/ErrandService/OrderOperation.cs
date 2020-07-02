using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeOutManagement
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

			orderList.Add(newOrder);
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

		public void OrderDel(uint ordernum)
		{
			int index = orderList.FindIndex(o => o.OrderID == ordernum);
			if (index != -1)
			{
				orderList.RemoveAt(index);
			}

		}



	}
	
	



}
