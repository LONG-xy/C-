using DormManagementApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class CallAtService_ManagerHost : Form
    {
        public Student Student { get; set; }
        List<CallAtApplication> SelectedApplications;
        List<CallAtApplication> AllApplications;
        Exception E = new OperationCanceledException();
        public CallAtService_ManagerHost()
        {
            InitializeComponent();
            AllApplicationSource.DataSource = AllApplications;
            ApplicationData.DataSource = AllApplicationSource;

            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

        }

        private void button1_Click(object sender, EventArgs e)//修改或者查看申请详情
        {
            try
            {
                ChangeStatus changeStatus = new ChangeStatus();
                if (ApplicationData.CurrentRow != null)
                {
                    int index = ApplicationData.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ApplicationData.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值
                    changeStatus.CurrentID = id;
                    changeStatus.ShowDialog();

                    if (changeStatus.DialogResult == DialogResult.OK)//更新窗口的表单项
                    {
                        string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var task1 = client.GetStringAsync(baseURL);
                        AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

                       
                    }
                }
                else { throw E; }
            }
            catch (OperationCanceledException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApplicationData.CurrentRow != null)
                {
                    int index = ApplicationData.CurrentRow.Index;    //取得选中行的索引  
                    int id = (int)ApplicationData.Rows[index].Cells["CallAtApplicationID"].Value;   //获取单元格的值

                    string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var task1 = client.DeleteAsync(baseURL);

                    //更新表单
                    
                    var task2 = client.GetStringAsync(baseURL);
                    AllApplications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task2.Result);
                }
                else if (ApplicationData.CurrentRow == null)
                {
                    MessageBox.Show("未选择数据");
                }
                else { throw E; }
            }
            catch (OperationCanceledException E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            string baseURL;
            if (IDtext != null)
            {
                baseURL = "https://localhost:5001/api/CallAtApplicationItems/?StudentID";///////////////

            }
            else { baseURL = "https://localhost:5001/api/CallAtApplicationItems"; }
            
            if (IDtext== null)
            {
                MessageBox.Show("查询信息不足，请重新输入");
            }
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            List<CallAtApplication> applications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);

            AllApplications = applications;
        }
    }
}
