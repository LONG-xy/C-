using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace DormManagementApp
{
    public class APIHelper
    {
        /// <summary>
        /// 上传录音文件
        /// </summary>
        /// <param name="address">文件上传到服务器的路径</param>
        /// <param name="fileNamePath">要上传的本地路径（全路径）</param>
        /// <param name="saveName">文件上传后的名称</param>
        /// <returns>成功返回1，失败返回2</returns>
        public static T PostFile<T>(string address, string fileNamePath, string saveName) where T : ApiResult, new()
        {
            T result = default(T);
            try
            {
                string returnValue = "";
                //要上传的文件
                using (FileStream fs = new FileStream(fileNamePath, FileMode.Open, FileAccess.Read))
                {
                    //二进制对象
                    using (BinaryReader r = new BinaryReader(fs))
                    {
                        //时间戳
                        string strBoundary = "----------" + DateTime.Now.Ticks.ToString("x");
                        byte[] boundaryBytes = Encoding.ASCII.GetBytes("\r\n--" + strBoundary + "\r\n");
                        //请求的头部信息
                        StringBuilder sb = new StringBuilder();
                        sb.Append("--");
                        sb.Append(strBoundary);
                        sb.Append("\r\n");
                        sb.Append("Content-Disposition: form-data; name=\"");
                        sb.Append("file");
                        sb.Append("\"; filename=\"");
                        sb.Append(saveName);
                        sb.Append("\";");
                        sb.Append("\r\n");
                        sb.Append("Content-Type: ");
                        sb.Append("application/octet-stream");
                        sb.Append("\r\n");
                        sb.Append("\r\n");
                        string strPostHeader = sb.ToString();
                        byte[] postHeaderBytes = Encoding.UTF8.GetBytes(strPostHeader);
                        // 根据uri创建HttpWebRequest对象   
                        HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(new Uri(address));
                        httpReq.Method = "POST";
                        //对发送的数据不使用缓存   
                        httpReq.AllowWriteStreamBuffering = false;
                        //设置获得响应的超时时间（300秒）   
                        httpReq.Timeout = 300000;
                        httpReq.ContentType = "multipart/form-data; boundary=" + strBoundary;
                        long length = fs.Length + postHeaderBytes.Length + boundaryBytes.Length;
                        long fileLength = fs.Length;
                        httpReq.ContentLength = length;

                        //每次上传4k  
                        int bufferLength = 4096;
                        byte[] buffer = new byte[bufferLength]; //已上传的字节数   
                        long offset = 0;         //开始上传时间   
                        DateTime startTime = DateTime.Now;
                        int size = r.Read(buffer, 0, bufferLength);
                        Stream postStream = httpReq.GetRequestStream();         //发送请求头部消息   
                        postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
                        while (size > 0)
                        {
                            postStream.Write(buffer, 0, size);
                            offset += size;
                            size = r.Read(buffer, 0, bufferLength);
                        }
                        //添加尾部的时间戳   
                        postStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                        postStream.Close();
                        //获取服务器端的响应   
                        WebResponse webRespon = httpReq.GetResponse();
                        Stream s = webRespon.GetResponseStream();
                        //读取服务器端返回的消息  
                        StreamReader sr = new StreamReader(s);
                        returnValue = sr.ReadLine();
                        s.Close();
                        sr.Close();
                    }
                }
                if (!String.IsNullOrEmpty(returnValue))
                    result = JsonConvert.DeserializeObject<T>(returnValue);
            }
            catch (Exception ex)
            {
                result = new T() { Code = 255, Msg = ex.Message };
            }
            finally
            {
            }
            return result;
        }


        public static T Get<T>(string url, Dictionary<string, object> parameters = null) where T : ApiResult, new()
        {
            return Response<T>(url, "get", parameters);
        }

        public static T Post<T>(string url, Dictionary<string, object> parameters = null) where T : ApiResult, new()
        {
            return Response<T>(url, "post", parameters);
        }


        public static T Response<T>(string url, string method, Dictionary<string, object> parameters = null) where T : ApiResult, new()
        {
            T result = default(T);
            try
            {
                HttpItem httpItem = new HttpItem() { };

                httpItem.Timeout = 30000;
                httpItem.URL = url;
                httpItem.Method = method;
                httpItem.Encoding = Encoding.UTF8;
                httpItem.ContentType = "application/x-www-form-urlencoded";

                if (httpItem.Method.ToLower() == "get")
                {
                    if (parameters != null && parameters.Count > 0)
                        if (httpItem.URL.Contains("?"))
                            httpItem.URL = httpItem.URL + "&" + BuildQuery(parameters, Encoding.UTF8);
                        else
                            httpItem.URL = httpItem.URL + "?" + BuildQuery(parameters, Encoding.UTF8);
                }
                else
                {
                    if (parameters != null)
                        httpItem.Postdata = BuildQuery(parameters, Encoding.UTF8);
                    httpItem.PostDataType = PostDataType.String;
                }
                HttpResult httpResult = new HttpHelper().GetHtml(httpItem);
                if (httpResult.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<T>(httpResult.Html);
                }
            }
            catch (Exception ex)
            {
                result = new T() { Code = 255, Msg = ex.Message };
            }
            return result;
        }

        /// <summary>
        ///     组装普通文本请求参数。
        /// </summary>
        /// <param name="parameters">Key-Value形式请求参数字典</param>
        /// <param name="charset">编码</param>
        /// <returns>URL编码后的请求数据</returns>
        private static string BuildQuery(IDictionary<string, object> parameters, Encoding encoding)
        {
            var postData = new StringBuilder();
            var hasParam = false;

            using (var dem = parameters.GetEnumerator())
            {
                while (dem.MoveNext())
                {
                    var name = dem.Current.Key;
                    string valueStr = string.Empty;
                    object valueObj = dem.Current.Value;
                    if (valueObj != null)
                        valueStr = valueObj.ToString();

                    // 忽略参数名或参数值为空的参数
                    if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(valueStr))
                    {
                        if (hasParam)
                            postData.Append("&");

                        postData.Append(name);
                        postData.Append("=");

                        var encodedValue = HttpUtility.UrlEncode(valueStr, encoding);

                        postData.Append(encodedValue);
                        hasParam = true;
                    }
                }
                return postData.ToString();
            }
        }
    }
}
