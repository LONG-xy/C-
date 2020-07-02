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

namespace DormManagementApp
{
    public partial class alter : Form
    {
        private studentMessage s;
        private int i;
        public alter(studentMessage s,int i)
        {
            this.s = s;
            this.i = i;
            InitializeComponent();
        }
        private Dictionary<string, string> dic = new Dictionary<string, string>();
        private void alter_Load(object sender, EventArgs e)
        {
            
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            if (i == choose.student)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = true;
            }
            textBox1.Text = s.dorms;
            textBox2.Text = s.phone;
            textBox3.Text = s.project;
            comboBox1.Text = s.states;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.dorms = textBox1.Text.Trim();
            s.phone = textBox2.Text.Trim();
            s.project = textBox3.Text.Trim();
            s.states = comboBox1.Text.Trim();


            dic.Add("xuehao", s.id);
            dic.Add("phone", s.phone);
            dic.Add("sushehao", s.dorms);
            dic.Add("xiangmu", s.project);
            dic.Add("states", s.states);
            Post("https://localhost:44396/api/students/updateStudent", dic);
            /*            try
                        {*/
            //MySqlConnection myConnection;
            //    string insertsql;
            //    myConnection = database.open();
            //    insertsql = string.Format("update student set phone='{0}',sushehao='{1}',xiangmu='{2}',states='{3}' where xuehao='{4}';",s.phone,s.dorms,s.project,s.states,s.id);
            //    MySqlCommand myCommand2 = new MySqlCommand(insertsql);
            //    myCommand2.Connection = myConnection;
            //    myConnection.Open();
            //    myCommand2.ExecuteNonQuery();
            //    myCommand2.Connection.Close();
            //    myConnection.Close();
            //    MessageBox.Show("修改成功。");
            /*            }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex + "\n修改失败。");
                        }*/
            this.Close();
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

    }
}
