using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DormManagementWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DomitoryController : ControllerBase
    {
        private SystemDbContext dbContext;
        public DomitoryController(SystemDbContext systemDbContext)
        {
            dbContext = systemDbContext;
        }

        [Route("Add")]
        [HttpGet]
        public OutputResult Add([FromForm] Domitory domitory)
        {
            if (dbContext.Domitorys.FirstOrDefault(x => x.DomitoryID == domitory.DomitoryID) != null)
                return OutputResult.Failed("已存在此宿舍号");

            dbContext.Domitorys.Add(domitory);
            if (dbContext.SaveChanges() < 1)
                return OutputResult.Failed("添加失败");

            return OutputResult.Success();
        }

        [Route("List")]
        [HttpGet]
        public OutputResult List(string id, string phone)
        {
            var temp = dbContext.Domitorys.AsEnumerable();

            if (!string.IsNullOrEmpty(id))
                temp = temp.Where(x => x.DomitoryID == Convert.ToInt64(id));

            if (!string.IsNullOrEmpty(phone))
                temp = temp.Where(x => x.PhoneNumber.Contains(phone));

            var list = temp.ToList();
            foreach (var item in temp)
            {
                item.Count = dbContext.Students.Where(x => x.RoomNumber == item.DomitoryID).Count();
            }
            return OutputResult<List<Domitory>>.Success(list);
        }
    }
}
