using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml;

namespace app
{
    public  partial class manage : Form
    {
        private StudentMessage stu = new StudentMessage();
        private int BOOL;
        private string s;
        public manage(string s, int B)
        {
            BOOL = B;
            this.s = s;
            InitializeComponent();
        }

        private void manage_Load(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            load();

        }

        private void show()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if (BOOL == choose.drom)
            {
                i = dgv.CurrentRow.Index;
                s = dgv.Rows[i].Cells["xuehao"].Value.ToString();
                MessageBox.Show(s);
                foreach (StudentMessage ss in StudentList.selectAllStudent())
                {
                    if (ss.id.Equals(s))
                    {
                        stu = ss;
                    }
                }
            }
            alter a = new alter(stu, BOOL);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            load();
        }
        private void load()
        {
            if (BOOL == choose.student)
            {
                button1.Text = "修改";
                foreach (StudentMessage ss in StudentList.selectAllStudent())
                {
                    if (ss.id.Equals(s))
                    {
                        show();

                        this.dgv.Columns.Add("电话",null);
                        this.dgv.Columns.Add("宿舍号", null);
                        this.dgv.Columns.Add("项目", null);
                        this.dgv.Columns.Add("状态", null);
                        this.dgv.Rows.Add(ss.phone, ss.dorms, ss.project, ss.states);
                        stu = ss;
                    }
                }
            }
            else
            {
                button1.Text = "修改报修状态";
                MySqlConnection myConnection;
                myConnection = database.open();
                MySqlDataAdapter ada = new MySqlDataAdapter("select *from student", myConnection);
                myConnection.Open();
                DataSet ds = new DataSet();
                ada.Fill(ds, "student");
                //ds.Tables.Add(Get("https://localhost:44396/api/students/getStudent"));
                dgv.DataSource = ds;
                dgv.DataMember = "student";
                myConnection.Close();
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 指定Url地址使用Get 方式获取全部字符串
        /// </summary>
        /// <param name="url">请求链接地址</param>
        /// <returns></returns>
        public static string Get(string url)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
         
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            
            Stream stream = resp.GetResponseStream();
      
            try
            {
               
                //获取内容
                using (StreamReader reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();
                    MessageBox.Show(result);


                }
            }
            finally
            {
                stream.Close();
            }
            return result;
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable ToDataTable(string json)
        {
            MessageBox.Show(json);
            DataTable dataTable = new DataTable();  //实例化


            DataTable result;
            try
            {
                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
                ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
                if (arrayList.Count > 0)
                {
                    foreach (Dictionary<string, object> dictionary in arrayList)
                    {
                        if (dictionary.Keys.Count<string>() == 0)
                        {
                            result = dataTable;
                            return result;
                        }
                        if (dataTable.Columns.Count == 0)
                        {
                            foreach (string current in dictionary.Keys)
                            {
                                dataTable.Columns.Add(current, dictionary[current].GetType());
                            }
                        }
                        DataRow dataRow = dataTable.NewRow();
                        foreach (string current in dictionary.Keys)
                        {
                            dataRow[current] = dictionary[current];
                        }

                        dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
                    }
                }
            }
            catch
            {
            }
        
            result = dataTable;
        
            return result;
        }
    }
}
