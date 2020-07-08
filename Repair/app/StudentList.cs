using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class StudentList
    {
        private static List<StudentMessage> stu = new List<StudentMessage>();
        public static List<StudentMessage> selectAllStudent()
        {
            MySqlConnection myConnection;
            myConnection = database.open();
            myConnection.Open();
            MySqlCommand myCommand = new MySqlCommand("select *from student", myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
            while (myReader.Read())
            {
                StudentMessage sm = new StudentMessage();
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
