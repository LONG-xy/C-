using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
	public class Order
	{
		private uint orderID;
		private User user;
		private double price;
		private string demand;
		private bool isPublisher;   //1:发布者 0：接单者
		private DateTime timeLimit;
		private State orderState;
		private Location startPoint;
		private Location endPoint;

		public enum Location{文理学部, 信息学部,工学部,医学部 }
		public enum State { Published,Taken,Fulfilled}
		public DateTime CreateTime{ get; set; }

		public User User { get => user; set => user = value; }
		public double Price { get => price; set => price = value; }
		public string Demand { get => demand; set => demand = value; }
		public bool IsPublisher { get => isPublisher; set => isPublisher = value; }
		public DateTime TimeLimit { get => timeLimit; set => timeLimit = value; }
		public State OrderState { get => orderState; set => orderState = value; }
		public uint OrderID { get => orderID; set => orderID = value; }
		public Location StartPoint { get => startPoint; set => startPoint = value; }
		public Location EndPoint { get => endPoint; set => endPoint = value; }


		//构造函数
		public Order() {
			this.OrderState = Order.State.Published;
			CreateTime = DateTime.Now;
			this.IsPublisher = true;
		}   
		public Order( User user, double price,DateTime timelimit,string demand)
		{
			this.User = user;
			this.Price = price;
			this.TimeLimit = timelimit;
			this.Demand = demand;
			this.CreateTime = DateTime.Now;
			this.OrderState = Order.State.Published;
			this.IsPublisher = true;
		}



		public void StateChangeToTaken()
		{
			if (this.OrderState == Order.State.Published)
				this.OrderState = Order.State.Taken;
			else if (this.OrderState == Order.State.Taken)
				this.OrderState = Order.State.Fulfilled;
			else
				throw new ApplicationException($"State Change Error：the order's state can't be changed!");

		}



		//重写
		public override string ToString()
		{
			
			return "User Name:" + User.UserName + "\r\n" + "Create Time:" + CreateTime + "\r\n"+"Publisher or Taker:"+IsPublisher+ "\r\n"
				+ "Demand:" + Demand+ "\r\n"+"Price"+Price+"Order State:"+OrderState+ "\r\n"+"Time Limit:"+TimeLimit;

		}



	

		public override int GetHashCode()
		{
			var hashCode = 1220661136;
			hashCode = hashCode * -1521134295 + orderID.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(user);
			hashCode = hashCode * -1521134295 + price.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(demand);
			hashCode = hashCode * -1521134295 + isPublisher.GetHashCode();
			hashCode = hashCode * -1521134295 + timeLimit.GetHashCode();
			hashCode = hashCode * -1521134295 + orderState.GetHashCode();
			hashCode = hashCode * -1521134295 + CreateTime.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
			hashCode = hashCode * -1521134295 + Price.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Demand);
			hashCode = hashCode * -1521134295 + IsPublisher.GetHashCode();
			hashCode = hashCode * -1521134295 + TimeLimit.GetHashCode();
			hashCode = hashCode * -1521134295 + OrderState.GetHashCode();
			hashCode = hashCode * -1521134295 + OrderID.GetHashCode();
			return hashCode;
		}

		public override bool Equals(object obj)
		{
			var order = obj as Order;
			return order != null &&
				   orderID == order.orderID &&
				   EqualityComparer<User>.Default.Equals(user, order.user) &&
				   price == order.price &&
				   demand == order.demand &&
				   isPublisher == order.isPublisher &&
				   timeLimit == order.timeLimit &&
				   orderState == order.orderState &&
				   CreateTime == order.CreateTime &&
				   EqualityComparer<User>.Default.Equals(User, order.User) &&
				   Price == order.Price &&
				   Demand == order.Demand &&
				   IsPublisher == order.IsPublisher &&
				   TimeLimit == order.TimeLimit &&
				   OrderState == order.OrderState &&
				   OrderID == order.OrderID;
		}
	}
}
