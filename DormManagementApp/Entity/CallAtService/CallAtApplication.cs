using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
    class CallAtApplication
    {
        public long CallAtApplicationID { get; set; }
        public long StudentID { get; set; }//住宿学生学号
        public string VisitorName { get; set; }//来访者姓名
        public DateTime CallAtTime { get; set; }//来访时间
        public string Remarks { get; set; }//备注，可为空，允许有空格
        public long RoomNumber { get; set; }//房间号
        public bool Status { get; set; }//宿管是否查看
        public bool IsApproved { get; set; }//宿管是否同意
        public CallAtApplication()
        {

        }
        public CallAtApplication(int applicationID, long studentID, string visitor, DateTime time, int room)
        {
            CallAtApplicationID = applicationID;
            StudentID = studentID;
            VisitorName = visitor;
            CallAtTime = time;
            RoomNumber = room;
            Status = false;
            IsApproved = false;
        }

        public override bool Equals(object obj)
        {
            CallAtApplication application = (CallAtApplication)obj;
            return application.CallAtApplicationID == CallAtApplicationID;
        }
        public override int GetHashCode()
        {
            string hash = this.ToString();
            int code = Int32.Parse(hash);
            return code;
        }
        public override string ToString()
        {
            string application = StudentID.ToString() + "/n" + VisitorName + "/n" + CallAtTime.ToString();
            return application;
        }

    }
}
