using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace DAL
{
    public class SQLHelper
    {
        //获取连接数据库字符串
        static string cnstr = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        /// <summary>
        /// 数据的增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string xuehao, string name, string phone, string sushehao, string xiangmu, string states)
        {
            MySqlConnection conn = new MySqlConnection(cnstr);
            conn.Open();
            Console.WriteLine(name);
            string sqlQuery = "insert into student(xuehao,name,phone,sushehao,xiangmu,states) values('"+xuehao+ "','" + name+ "','" + phone + "','" + sushehao + "','" +xiangmu + "','" + states + "')";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            int r= comm.ExecuteNonQuery();
            conn.Close();
            return r;
        }
        public static int ExecuteNonQuery(string phone, string sushehao, string xiangmu, string states, string xuehao)
        {
            MySqlConnection conn = new MySqlConnection(cnstr);
            conn.Open();
            string sqlQuery = "update student set phone='"+phone+ "',sushehao='" + sushehao + "',xiangmu='" +xiangmu + "',states='" +states + "' where xuehao='" + xuehao + "'";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            int r = comm.ExecuteNonQuery();
            
            conn.Close();
            return r;
        }
      
        /// <summary>
        /// 对数据库执行查询操作，返回DataSet结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset()
        {
            MySqlConnection conn = new MySqlConnection(cnstr);
            conn.Open();
            string sqlQuery = "select * from student";
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            da.SelectCommand = comm;
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
   
            conn.Close();
            return ds;
        }
        /// <summary>
        /// 对数据库进行查询操作，返回DataReader对象
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="type"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, CommandType type, SqlParameter[] p)
        {
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = type;
            if (p != null)
            {
                cmd.Parameters.AddRange(p);
            }
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            return dr;
        }
    }
}
