using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ResponseData
    {
        //响应数据
        public int Code { get; set; } = 200;  //状态码 默认正常

        public object Data { get; set; }//数据

        public string ErrorMessage { get; set; }//错误信息
    }
}
