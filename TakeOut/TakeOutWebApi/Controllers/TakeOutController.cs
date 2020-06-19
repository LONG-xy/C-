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
    public class TakeOutController : ControllerBase
    {
        private readonly TakeOutContext TakeOutDb;

        //构造函数把TakeOutContext 作为参数，Asp.net core 框架可以自动注入TakeOutContext对象
        public TakeOutController(TakeOutContext context)
        {
            this.TakeOutDb = context;
        }

        // GET: api/TakeOut/SelectTakeOutOrder
        [Route("SelectTakeOutOrder")]
        [HttpGet]
        public List<TakeOutOrder> Tables()
        {

            var row = (from i in TakeOutDb.TakeOutOrders
                       select i).ToList();

            return row;
        } //输出所有外卖订单信息

        // GET: api/TakeOut/StuIDGetStudent
        [Route("StuIDGetStudent")]
        [HttpGet]
        public List<Student> StuIDGetStudent(string studentid)
        {
            IQueryable<Student> query = TakeOutDb.Students;

            query = query.Where(t => t.StudentID == Convert.ToInt32(studentid));

            return query.ToList();

        } //根据学号查询学生信息

        //Post: api/TakeOut/AddOrder?PhoneNumber=1234567&TakeOutOrderID=1
        [Route("AddOrder")]
        [HttpPost]       
        public string AddOrder(string phonenumber,string takeoutorderid)
        {
            var student = TakeOutDb.Students.FirstOrDefault(t => t.PhoneNumber == Convert.ToInt32(phonenumber));
            if (student != null)
            {
                TakeOutOrder t = new TakeOutOrder();
                t.StudentID = student.StudentID;
                t.Name = student.Name;
                t.PhoneNumber = student.PhoneNumber;
                t.TakeOutOrderID = Convert.ToInt32(takeoutorderid);
                t.State = "已达";
                TakeOutDb.TakeOutOrders.Add(t);
                TakeOutDb.SaveChanges();
                return "OK";
            }
            else return "False";
        } //录入外卖订单信息

        // PUT: api/TakeOut/UpdateOrder?TakeOutOrderID=1
        [Route("UpdateOrder")]
        [HttpPut]
        public string UpdateOrder(string takeoutorderid)
        {
           var takeoutorder = TakeOutDb.TakeOutOrders.FirstOrDefault(t => t.TakeOutOrderID == Convert.ToInt32(takeoutorderid));
           TakeOutOrder t = new TakeOutOrder();
            t.TakeOutOrderID = takeoutorder.TakeOutOrderID;
            t.StudentID = takeoutorder.StudentID;
            t.Name = takeoutorder.Name;
            t.PhoneNumber = takeoutorder.PhoneNumber;
            t.State = "已取";
            TakeOutDb.Entry(t).State = EntityState.Modified;
            TakeOutDb.SaveChanges();
            return "OK";
        }

        // DELETE: api/TakeOut/DeleteOrder?TakeOutOrderID=1
        [Route("DeleteOrder")]
        [HttpDelete]
        public string DeleteOrder(string takeoutorderid)
        {
           var takeoutorder = TakeOutDb.TakeOutOrders.FirstOrDefault(t => t.TakeOutOrderID == Convert.ToInt32(takeoutorderid));
            if (takeoutorder != null)
            {
                TakeOutDb.TakeOutOrders.Remove(takeoutorder);
                TakeOutDb.SaveChanges();
                return "OK";
            }
           else return "False";
        } //删除外卖订单信息

    }
}
