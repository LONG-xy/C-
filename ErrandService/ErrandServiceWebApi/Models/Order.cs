using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DormManagementApi.Models
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


		public enum Location { 文理学部, 信息学部, 工学部, 医学部 }
		public enum State { Published, Taken, Fulfilled }
		public DateTime CreateTime { get; set; }

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
		public Order()
		{
			this.OrderState = Order.State.Published;
			CreateTime = DateTime.Now;
			this.IsPublisher = true;
		}
		public Order(User user, double price, DateTime timelimit, string demand)
		{
			this.User = user;
			this.Price = price;
			this.TimeLimit = timelimit;
			this.Demand = demand;
			this.CreateTime = DateTime.Now;
			this.OrderState = Order.State.Published;
			this.IsPublisher = true;
		}
	}
}
