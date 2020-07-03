using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DormManagementApp
{
    public class database
    {
        public static MySqlConnection open()
        {
            string connstring = "";
            if (connstring == "")
            {
                connstring = "Database=mydatadb;Data Source=localhost;User Id=root;Password=;charset=utf8";
            }
            MySqlConnection myConnection = new MySqlConnection(connstring);
            try
            {
                myConnection = new MySqlConnection(connstring);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return myConnection;
        }
    }
}
