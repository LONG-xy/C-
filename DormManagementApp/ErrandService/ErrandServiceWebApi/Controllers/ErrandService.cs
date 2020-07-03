using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DormManagementApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;





namespace DormManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErrandService : ControllerBase
    {
        private readonly ErrandServiceContext ErrandServiceDb;
		Random rnd = new Random();


        //构造函数把ESContext 作为参数，Asp.net core 框架可以自动注入ErrandServiceContext对象
        public ErrandService(ErrandServiceContext context)
        {
            this.ErrandServiceDb = context;
        }

		//// GET: api/ErrandService/SelectOrder
		//[Route("SelectOrder")]
  //      [HttpGet]
  //      public List<Order> Tables()
  //      {

  //          var row = (from i in ErrandServiceDb.Orders
  //                     select i).ToList();

  //          return row;
  //      } //输出所有信息















        // GET: api/TakeOut/GetOrderTable
        [Route("GetOrderTable")]
        [HttpGet]
        public List<Order> GetOrderTable()
        {
            IQueryable<Order> query = ErrandServiceDb.Orders;
           // query = query.Where(t => t.StudentID == Convert.ToInt32(studentid));
            return query.ToList();


        } //根据查询信息

		[Route("GetPublicOrderTable")]
		[HttpGet]
		public List<Order> GetPublicOrderTable()
		{
			IQueryable<Order> query = ErrandServiceDb.PublicOrders;
			// query = query.Where(t => t.StudentID == Convert.ToInt32(studentid));
			return query.ToList();


		} //根据查询信息



		//Post: api/
		[Route("AddOrder")]
        [HttpPost]       
        public string AddOrder(Order order)
        {
			order.OrderID = rnd.Next();
			ErrandServiceDb.Orders.Add(order);
                ErrandServiceDb.SaveChanges();
                return "OK";
           
        } //录入订单信息
		  //Post: api/
		[Route("AddPublicOrder")]
		[HttpPost]
		public string AddOrder(Order order)
		{
			order.OrderID = rnd.Next();
			ErrandServiceDb.PublicOrders.Add(order);
			ErrandServiceDb.SaveChanges();
			return "OK";

		} //录入订单信息

		// PUT: api/
		[Route("UpdateOrder")]
        [HttpPut]
        public string UpdateOrder(Order newOrder)
        {
			var oldOrder = ErrandServiceDb.Orders.FirstOrDefault(t => t.OrderID == Convert.ToInt32(newOrder.OrderID));
			
			ErrandServiceDb.Orders.Remove(oldOrder);
			ErrandServiceDb.Orders.Add(newOrder);
			ErrandServiceDb.SaveChanges();
            return "OK";
        }


        // DELETE: api/
        [Route("DeleteOrder")]
        [HttpDelete]
        public string DeleteOrder(string orderid)
        {
           var order = ErrandServiceDb.Orders.FirstOrDefault(t => t.OrderID == Convert.ToInt32(orderid));
            if (order != null)
            {
                ErrandServiceDb.Orders.Remove(order);
                ErrandServiceDb.SaveChanges();
                return "OK";
            }
           else return "False";
        } //删除订单信息
		

	}
}
