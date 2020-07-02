using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class ModifyStudent : Form
    {
        private Student Student { get; set; }
        public ModifyStudent(Student student)
        {
            InitializeComponent();
            Student = student;
        }

        protected override void OnShown(EventArgs e)
        {
            //List<Domitory> list = new List<Domitory>();
            //var result = APIHelper.Post<ApiResult<List<Domitory>>>(WebSetting.GetUrl("Domitory/List"));

            //if (result.Code == 0)
            //{
            //    list = result.Data;
            //}

            //if (list.Count < 1)
            //    MessageBox.Show("没有宿舍可选");

            this.textBox1.Text = Student.No;
            this.textBox2.Text = Student.Name;
            this.textBox3.Text = Student.PhoneNumber;
            this.textBox4.Text = Student.SubjectName;
            this.textBox5.Text = Student.ClassName;

            base.OnShown(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = this.textBox1.Text;
            string name = this.textBox2.Text;
            string phone = this.textBox3.Text;
            string subject = this.textBox4.Text;
            string className = this.textBox5.Text;
            Student student = new Student()
            {
                StudentID = no,
                Name = name,
                PhoneNumber = phone,
                SubjectName = subject,
                ClassName = className
            };

            var result = APIHelper.Post<ApiResult>(WebSetting.GetUrl("Student/Modify"),
                new Dictionary<string, object>() {
                    { "StudentID", student.StudentID },
                    { "Name", student.Name },
                    { "PhoneNumber", student.PhoneNumber } ,
                    { "SubjectName", student.SubjectName } ,
                    { "ClassName", student.ClassName }
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
