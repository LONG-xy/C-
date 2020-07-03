using DormManagementApp;
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
    public partial class ChangeStatus : Form
    {
        CallAtApplication current = new CallAtApplication();
        public int CurrentID { get; set; }
        string baseURL;
        public ChangeStatus()
        {
            InitializeComponent();
            current.Status = false;
            current.IsApproved = false;
            baseURL = "https://localhost:5001/api/CallAtApplicationItems/" + CurrentID.ToString();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task1 = client.GetStringAsync(baseURL);
            List<CallAtApplication> applications = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            current = applications[0];
            NameLable.Text = current.VisitorName;
            RoomLable.Text = current.RoomNumber.ToString();
            TimeLable.Text = current.CallAtTime.ToString();
            RemarkLable.Text = current.Remarks.ToString();
            if (current.Status == true)
            {
                if (current.IsApproved == true)
                {
                    CallAtApproved.Checked = true;
                }
                else CallAtDenied.Checked = true;
            }

        }

        private void CheckOK_Click(object sender, EventArgs e)
        {
            if (current.Status == true)
            {
                this.Close();
            }
            else
            {
                if (CallAtApproved.Checked == true)
                {
                    baseURL = "https://localhost:5001/api/CallAtApplicationItems/" + CurrentID.ToString();
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    current.Status = true;
                    current.IsApproved = true;

                    HttpContent content = new StringContent(JsonConvert.SerializeObject(current), Encoding.UTF8, "application/json");
                    var task = client.PutAsync(baseURL, content);
                    task.Wait();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else if (CallAtDenied.Checked == true)
                {
                    baseURL = "https://localhost:5001/api/CallAtApplicationItems/" + CurrentID.ToString();
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    current.Status = true;
                    current.IsApproved = false;

                    HttpContent content = new StringContent(JsonConvert.SerializeObject(current), Encoding.UTF8, "application/json");
                    var task = client.PutAsync(baseURL, content);
                    task.Wait();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else//没有修改任何选项
                {
                    MessageBox.Show("请勾选同意或拒绝，再确认。");
                }
            }


        }

        private void CallAtApproved_CheckedChanged(object sender, EventArgs e)
        {
            if (current.Status == true)
            {
                MessageBox.Show("此申请已经查阅，请不要改动。");
                if (CallAtApproved.Checked == true)
                    CallAtApproved.Checked = false;
                else CallAtApproved.Checked = true;
            }
            else
            {
                if (CallAtDenied.Checked == true && CallAtApproved.Checked == true)
                {
                    MessageBox.Show("不可重复选择！");
                    CallAtApproved.Checked = false;
                }
            }
        }

        private void CallAtDenied_CheckedChanged(object sender, EventArgs e)
        {
            if (current.Status == true)
            {
                MessageBox.Show("此申请已经查阅，请不要改动。");
                if (CallAtDenied.Checked == true)
                    CallAtDenied.Checked = false;
                else CallAtDenied.Checked = true;
            }
            else
            {
                if (CallAtDenied.Checked == true && CallAtApproved.Checked == true)
                {
                    MessageBox.Show("不可重复选择！");
                    CallAtDenied.Checked = false;
                }
            }
        }
    }
}
