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
    public partial class ChangeCallAtApplication_student : Form
    {
        public long Index { get; set; }
        CallAtApplication application = new CallAtApplication();
        public ChangeCallAtApplication_student()
        {
            InitializeComponent();
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems" + Index.ToString();
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task1 = client.GetStringAsync(baseURL);
            List<CallAtApplication> todos = JsonConvert.DeserializeObject<List<CallAtApplication>>(task1.Result);
            application = todos[0];
            VisitorName.Text = application.VisitorName;
            dateTimePicker.Text = application.CallAtTime.ToString();
            Remarks.Text = application.Remarks;
        }

        private void ChangeOK_Click(object sender, EventArgs e)
        {
           
        }

        private void ChangeCancle_Click(object sender, EventArgs e)
        {
            
        }

        private void AddOK_Click(object sender, EventArgs e)
        {
            if (application.Status == true)
            {
                MessageBox.Show("已经被管理员受理！");
                this.Close();
                this.DialogResult = DialogResult.Cancel;
            }
            else if (VisitorName.Text == null || dateTimePicker.Text == null)
            {
                MessageBox.Show("信息不完整！");

            }
            else
            {
                application.VisitorName = VisitorName.Text;
                application.CallAtTime = DateTime.Parse(dateTimePicker.Text);
                application.Remarks = Remarks.Text;

                string baseURL = "https://localhost:5001/api/CallAtApplicationItems" + Index.ToString();
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpContent content = new StringContent(JsonConvert.SerializeObject(application), Encoding.UTF8, "application/json");
                var task = client.PutAsync(baseURL, content);
                task.Wait();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void AddDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}