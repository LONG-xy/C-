
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace DormManagementWeb
{
    /// <summary>
    ///接口输出结果对象
    /// </summary>
    public class OutputResult
    {
        /// <summary>
        ///接口输出结果对象
        /// </summary>
        public OutputResult()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="code">状态编码</param>
        /// <param name="msg">状态描述</param>
        public OutputResult(int code, string msg)
            : this()
        {
            Code = code;
            Msg = msg;
        }

        /// <summary>
        /// 创建一个请求成功的返回结果
        /// </summary>
        /// <returns></returns>
        public static OutputResult Success()
        {
            return new OutputResult(0, "成功");
        }
        /// <summary>
        /// 创建一个请求失败的返回结果
        /// </summary>
        /// <returns></returns>
        public static OutputResult Failed(string msg)
        {
            return Failed(255, msg);
        }

        /// <summary>
        /// 创建一个请求失败的返回结果
        /// </summary>
        /// <returns></returns>
        public static OutputResult Failed(int code, string msg)
        {
            return new OutputResult(code, msg);
        }
        /// <summary>
        /// 状态编码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 状态描述
        /// </summary>
        public string Msg { get; set; }
    }

    /// <summary>
    ///泛型接口输出结果对象
    /// </summary>
    public class OutputResult<T> : OutputResult
    {
        /// <summary>
        /// 泛型数据
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 接口输出结果对象
        /// </summary>
        /// <param name="stateCode">状态编码</param>
        /// <param name="stateMsg">状态描述</param>
        public OutputResult(int stateCode, string stateMsg)
            : base(stateCode, stateMsg)
        {
            Data = default(T);
        }

        /// <summary>
        /// 创建一个请求成功的泛型返回结果
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static OutputResult<T> Success(T t)
        {
            return new OutputResult<T>(0, "成功") { Data = t };
        }
    }
}