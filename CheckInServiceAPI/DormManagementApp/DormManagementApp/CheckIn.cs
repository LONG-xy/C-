using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class CheckIn : Form
    {
        private Student Student { get; set; }
        public CheckIn(Student student)
        {
            InitializeComponent();
            Student = student;
        }


        protected override void OnShown(EventArgs e)
        {

            List<Domitory> list = new List<Domitory>();
            var result = APIHelper.Post<ApiResult<List<Domitory>>>(WebSetting.GetUrl("Domitory/List"));

            if (result.Code == 0)
            {
                list = result.Data;
            }
            if (list.Count < 1)
                MessageBox.Show("没有宿舍可选择");

            this.comboBox1.DisplayMember = "DomitoryID";
            this.comboBox1.ValueMember = "DomitoryID";
            this.comboBox1.DataSource = list;

            this.textBox1.Text = Student.No;
            this.textBox2.Text = Student.Name;
            this.textBox3.Text = Student.PhoneNumber;
            this.textBox4.Text = Student.SubjectName;
            this.textBox5.Text = Student.ClassName;
            this.dateTimePicker1.Value = DateTime.Now;

            if (!string.IsNullOrEmpty(Student.DomitoryID))
                this.comboBox1.SelectedValue = Student.DomitoryID;

            if (Student.CheckInTime.HasValue)
                this.dateTimePicker1.Value = Student.CheckInTime.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string domitoryNo = this.comboBox1.SelectedValue != null ? this.comboBox1.SelectedValue.ToString() : "";
            if (string.IsNullOrEmpty(domitoryNo))
            {
                MessageBox.Show("请选择宿舍");
                return;
            }

            Student.DomitoryID = domitoryNo;
            Student.CheckInTime = this.dateTimePicker1.Value;


            var result = APIHelper.Post<ApiResult>(WebSetting.GetUrl("Student/CheckIn"),
                new Dictionary<string, object>() {
                    { "id", Student.StudentID },
                    { "DomitoryID", Student.DomitoryID } ,
                    { "CheckInTime", Student.CheckInTime } ,
                });

            if (result.Code == 0)
                MessageBox.Show(result.Msg);
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
