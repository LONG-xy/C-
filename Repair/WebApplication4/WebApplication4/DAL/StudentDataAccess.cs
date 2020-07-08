using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{
    public class StudentDataAccess
    {
       /// <summary>
       /// 添加信息
       /// </summary>
       /// <param name="xuehao"></param>
       /// <param name="name"></param>
       /// <param name="phone"></param>
       /// <param name="sushehao"></param>
       /// <param name="states"></param>
       /// <returns></returns>
        public static bool AddStudent(string xuehao, string name, string phone, string sushehao, string xiangmu, string states)
        {
            
            int i = SQLHelper.ExecuteNonQuery(xuehao,name,phone,sushehao,xiangmu,states);
            return i > 0;
        }
        public static bool updateStudent(string phone, string sushehao, string xiangmu, string states,string xuehao)
        {

            int i = SQLHelper.ExecuteNonQuery(phone, sushehao, xiangmu, states,xuehao);
            return i > 0;
        }
        public static DataSet getStudent()
        {
            return SQLHelper.ExecuteDataset();
        }
    }
}