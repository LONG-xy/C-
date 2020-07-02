using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
    class studentList
    {
        private static List<studentMessage> stu = new List<studentMessage>();
        public static List<studentMessage> selectAllStudent()
        {
            MySqlConnection myConnection;
            myConnection = database.open();
            myConnection.Open();
            MySqlCommand myCommand = new MySqlCommand("select *from student", myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (myReader.Read())
            {
                studentMessage sm = new studentMessage();
                sm.id = myReader["xuehao"].ToString();
                sm.name = myReader["name"].ToString();
                sm.phone = myReader["phone"].ToString();
                sm.dorms = myReader["sushehao"].ToString();
                sm.project = myReader["xiangmu"].ToString();
                sm.states = myReader["states"].ToString();
                stu.Add(sm);
            }
            myConnection.Close();
            return stu;
        }
    }
}
