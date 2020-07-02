using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManagementApp
{

    public partial class CallAtService_StudentHost : Form
    {
        public Student Student { get; set; }
        List<CallAtApplication> AllApplications;
        long ID ;
        public CallAtService_StudentHost()
        {
            InitializeComponent();
            ApplicationData.DataSource = AllApplications;

            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
        }

        private void AddCallAtApplication_Click(object sender, EventArgs e)
        {
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            int index = AllApplications.Count;
            ID = AllApplications[index].CallAtApplicationID;

            AddCallAtApplication addCallAt = new AddCallAtApplication();
            addCallAt.CurrentStudent = Student;
            addCallAt.ID = ID;
            addCallAt.ShowDialog();
            if (addCallAt.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("添加成功！");
                baseURL = "https://localhost:5001/api/CallAtApplicationItems";//////////

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var task2 = client.GetStringAsync(baseURL);
                AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task2.Result);

            }
            else MessageBox.Show("添加操作取消");
        }

        private void ChangeCallAtApplication_Click(object sender, EventArgs e)
        {
            ChangeCallAtApplication_student change = new ChangeCallAtApplication_student();
                if (ApplicationData.CurrentRow != null)
                {
                    int index = ApplicationData.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ApplicationData.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值
                    change.Index = id;
                    change.ShowDialog();

                    if (change.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                    }
                    else if (change.DialogResult == DialogResult.Cancel)
                    {
                        MessageBox.Show("操作已取消！");
                    }
                }
                else
                {
                    MessageBox.Show("未选择数据");
                }
        }

        private void button1_Click(object sender, EventArgs e)//按照日期查询
        {
            string dateTime = dateTimePicker1.Text;
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems" + dateTime;//////////////////////////
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task.Result);

        }

        private void DeleteApplication_Click(object sender, EventArgs e)
        {
            if (ApplicationData.CurrentRow != null)
            {
                int index = ApplicationData.CurrentRow.Index;    //取得选中行的索引  
                ID = (long)ApplicationData.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值

                string baseURL = "https://localhost:5001/api/CallAtApplicationItems"+ID.ToString();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var task1 = client.DeleteAsync(baseURL);

                //更新表单
                baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                var task2 = client.GetStringAsync(baseURL);
                AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task2.Result);
            }
            else if (ApplicationData.CurrentRow != null)
            {
                MessageBox.Show("未选择数据");
            }
        }
    }
}
