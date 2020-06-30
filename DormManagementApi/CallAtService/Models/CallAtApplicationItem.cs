using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DormManagementApi.Models
{
    public class CallAtApplicationItem
    {
         public long Id { get; set; }
            
         public long StudentID { get; set; }//住宿学生学号
         public string VisitorName { get; set; }//来访者姓名
         public DateTime CallAtTime { get; set; }//来访时间
         public List<string> Remarks { get; set; }//备注，可为空，允许有空格
         public int RoomNumber { get; set; }//房间号
         public bool Status { get; set; }//宿管是否查看
         public bool IsApproved { get; set; }//宿管是否同意

    }
}
