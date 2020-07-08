using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebApplication4.BLL_
{
    public class StudentBusiness
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
        public static bool AddStudent(string xuehao,string name,string phone,string sushehao,string xiangmu,string states )
        {
            return DAL.StudentDataAccess.AddStudent(xuehao,name,phone,sushehao,xiangmu,states);
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="xuehao"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="sushehao"></param>
        /// <param name="states"></param>
        /// <returns></returns>
        public static bool updateStudent( string phone, string sushehao, string xiangmu, string states, string xuehao)
        {
            return DAL.StudentDataAccess.updateStudent( phone, sushehao, xiangmu, states,xuehao);
        }
        public static DataSet getStudent()
        {
            return DAL.StudentDataAccess.getStudent();
        }
    }
}