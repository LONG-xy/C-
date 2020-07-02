using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DormManagementApp
{
    public class Student : EntityBase
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string DomitoryID { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? CheckInTime { get; set; }

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
