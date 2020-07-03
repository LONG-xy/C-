using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DormManagementWeb.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private SystemDbContext dbContext;
        public StudentController(SystemDbContext systemDbContext)
        {
            dbContext = systemDbContext;
        }

        [Route("Add")]
        [HttpPost]
        public OutputResult Add([FromForm] Student student)
        {
            if (dbContext.Students.FirstOrDefault(x => x.StudentID == student.StudentID) != null)
                return OutputResult.Failed("已存在此学号");

            dbContext.Students.Add(student);
            if (dbContext.SaveChanges() < 1)
                return OutputResult.Failed("添加失败");

            return OutputResult.Success();
        }

        [Route("Modify")]
        [HttpPost]
        public OutputResult Modify([FromForm] Student student)
        {
            var oldStudent = dbContext.Students.FirstOrDefault(x => x.StudentID == student.StudentID);
            if (oldStudent == null)
                return OutputResult.Failed("不存在此学生");

            oldStudent.Name = student.Name;
            oldStudent.PhoneNumber = student.PhoneNumber;
            oldStudent.ClassName = student.ClassName;
            oldStudent.SubjectName = student.SubjectName;

            dbContext.Entry(oldStudent).State = EntityState.Modified;
            if (dbContext.SaveChanges() < 1)
                return OutputResult.Failed("添加失败");

            return OutputResult.Success();
        }

        [Route("CheckIn")]
        [HttpPost]
        public OutputResult CheckIn(string id, long domitoryId, DateTime checkInTime)
        {
            var student = dbContext.Students.FirstOrDefault(x => x.StudentID == Convert.ToInt64(id));
            if (student == null)
                return OutputResult.Failed("不存在此学生");

            student.RoomNumber = domitoryId;
            student.CheckInTime = checkInTime;

            dbContext.Entry(student).State = EntityState.Modified;
            if (dbContext.SaveChanges() < 1)
                return OutputResult.Failed("添加失败");

            return OutputResult.Success();
        }

        [Route("CheckOut")]
        [HttpPost]
        public OutputResult CheckOut(string id)
        {
            var student = dbContext.Students.FirstOrDefault(x => x.StudentID == Convert.ToInt64(id));
            if (student == null)
                return OutputResult.Failed("不存在此学生");

            student.RoomNumber = 0;
            student.CheckInTime = null;

            dbContext.Entry(student).State = EntityState.Modified;
            if (dbContext.SaveChanges() < 1)
                return OutputResult.Failed("退宿失败");

            return OutputResult.Success();
        }


        [Route("Single")]
        [HttpGet]
        public OutputResult Single(string id)
        {
            var student = dbContext.Students.FirstOrDefault(x => x.StudentID == Convert.ToInt64(id));
            if (student == null)
                return OutputResult.Failed("不存在此学生");

            return OutputResult<Student>.Success(student);
        }

        [Route("List")]
        [HttpGet]
        public OutputResult List(string id, string domitoryId)
        {
            var temp = dbContext.Students.AsEnumerable();

            if (!string.IsNullOrEmpty(id))
                temp = temp.Where(x => x.StudentID == Convert.ToInt64(id));

            if (!string.IsNullOrEmpty(domitoryId))
                temp = temp.Where(x => x.RoomNumber == Convert.ToInt64(domitoryId));
            return OutputResult<List<Student>>.Success(temp.ToList());
        }
    }
}
