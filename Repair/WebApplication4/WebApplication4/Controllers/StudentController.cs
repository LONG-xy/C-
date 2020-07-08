using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Services;
using Test1.Models;
using WebApplication4.BLL_;

namespace Test1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/students")]
    public class StudentController:ApiController
    {
        static readonly IStudedntRepository repository = new StudentRepository();
        public IEnumerable<Student> GetListAll()
        {
            return repository.GetAll();
        }
        [HttpPost]
        [Route("AddStudent")]//添加信息
        public IHttpActionResult AddStudent( Student student)
        {
           
            StudentBusiness.AddStudent(student.xuehao,student.name,student.phone,student.sushehao,student.xiangmu,student.states);
            return Ok(new ResponseData());
        }
        [HttpPost]
        [Route("updateStudent")]//修改
        public IHttpActionResult updateStudent(Student student)
        {

            StudentBusiness.updateStudent(student.phone, student.sushehao, student.xiangmu, student.states,student.xuehao);
            return Ok(new ResponseData());
        }
        [HttpGet]
        [Route("getStudent")]//获取所有
        public IHttpActionResult GetContentList()
        {
            return Ok(StudentBusiness.getStudent());
        }
        

    }

}