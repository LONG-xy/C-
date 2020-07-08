using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task10WebApi;

namespace app
{
    public partial class repairAdd : Form
    {
        private studentMessage sm = new studentMessage();
        private  Dictionary<string, string> dic = new Dictionary<string,string>();
        database db = new database();
        public repairAdd()
        {

            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            sm.id = textBox1.Text.Trim();
            sm.name = textBox2.Text.Trim();
            sm.phone = textBox3.Text.Trim();
            sm.dorms = textBox4.Text.Trim();
            sm.project = textBox5.Text.Trim();
            sm.states = status.dispose;
            bool b = false;

            dic.Add("xuehao", sm.id);
            dic.Add("name", sm.name);
            dic.Add("phone", sm.phone);
            dic.Add("sushehao", sm.dorms);
            dic.Add("xiangmu", sm.project);
            dic.Add("states", sm.states);
            if (textBox1.Text.Trim()!="")
            {
               link();
             
         Post("https://localhost:44396/api/students/AddStudent", dic);
                MessageBox.Show("报修成功。");
            }
            else
            {
                MessageBox.Show("请重新输入学号。");
                textBox1.Text = "";
            }
            
        }
        /// <summary>
        /// 指定Post地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求后台地址</param>
        /// <returns></returns>
        public static string Post(string url, Dictionary<string, string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                    builder.Append("&");
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            return result;
        }

     
        private void link()
        {
            try
            {
                MySqlConnection myConnection;
                string insertsql;
                myConnection = database.open();
                insertsql = string.Format("insert into student(学号, 姓名, 手机号, 宿舍号, 报修项目,报修状态) values('{0}','{1}','{2}',{3},'{4}','{5}'); ", sm.id, sm.name, sm.phone, sm.dorms, sm.project, sm.states);
                MySqlCommand myCommand2 = new MySqlCommand(insertsql);
                myCommand2.Connection = myConnection;
                myConnection.Open();
                myCommand2.ExecuteNonQuery();
                myCommand2.Connection.Close();
                myConnection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex+"\n报修失败。");
            }
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void repairAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
