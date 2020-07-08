using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class StudentMessage
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string dorms { get; set; }
        public string project { get; set; }
        public string states { get; set; }

        public StudentMessage(){}

        public StudentMessage(string id, string name, string phone, string dorms, string project, string states)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.dorms = dorms;
            this.project = project;
            this.states = states;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("学号：" + id + "姓名：" + name + "手机号：" + phone + "宿舍号：" + dorms + "报修项目：" + project + "报修状态：" + states);
            return sb.ToString();
        }
    }
}
