using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
    public class ApiResult
    {
        public ApiResult()
        {

        }
        public ApiResult(int code, string msg)
        {
            Code = code;
            Msg = msg;
        }
        public int Code { get; set; }
        public string Msg { get; set; }

        public static ApiResult Success()
        {
            return new ApiResult(0, "");
        }

        public static ApiResult Fail(string msg, int code = 255)
        {
            return new ApiResult(code, msg);
        }
    }

    public class ApiResult<T> : ApiResult
    {
        public T Data { get; set; }
    }
}
