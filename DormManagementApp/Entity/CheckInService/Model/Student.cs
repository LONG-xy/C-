using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DormManagementApp
{
    public class Student
    {
        public long StudentID { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public long RoomNumber { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime? CheckInTime { get; set; }

        public long AccountNumber { set; get; }
        public string Password { set; get; }

    }

    public enum Sex
    {
        /// <summary>
        /// 发起退款
        /// </summary>
        [Description("男")]
        Man = 0,
        /// <summary>
        /// 发起退款
        /// </summary>
        [Description("女")]
        WoMan = 1
    }
}
