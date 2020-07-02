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
    public partial class AddCallAtApplication : Form
    {
        public Student CurrentStudent { set; get; }
        public long ID { set; get; }
        public AddCallAtApplication()
        {
            InitializeComponent();
        }

        private void AddOK_Click(object sender, EventArgs e)
        {
            CallAtApplication callAt = new CallAtApplication();
            string baseURL = "https://localhost:5001/api/CallAtApplicationItems";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            if (VisitorName.Text == null || Room.Text == null)
            {
                MessageBox.Show("信息填写不完整！");
            }
            else
            {
                callAt.CallAtApplicationID = ID + 1;
                callAt.CallAtTime = DateTime.Parse(dateTimePicker.Text);
                callAt.VisitorName = VisitorName.Text;
                callAt.IsApproved = false;
                callAt.Remarks = Remarks.Text;
                callAt.RoomNumber = CurrentStudent.RoomNumber;
                callAt.Status = false;
                callAt.StudentID = CurrentStudent.StudentID;

                HttpContent content = new StringContent(JsonConvert.SerializeObject(callAt), Encoding.UTF8, "application/json");
                var task = client.PostAsync(baseURL, content);
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
