using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TakeOutManagement;

namespace DormManagementApp
{
    public partial class student : Form
    {
        public Student Student { get; set; }
        public bool IsStudent { get; set; }
        public student()
        {
            InitializeComponent();
            if (Student != null)
            {
                IsStudent = true;
            }
            else IsStudent = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            repairAdd r = new repairAdd();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sno s = new Sno();
            s.Show();
        }

        private void 来访ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsStudent == true)
            {
                CallAtService_StudentHost studentHost = new CallAtService_StudentHost();
                studentHost.Student = this.Student;
                studentHost.Show();
            }
            else
            {
                CallAtService_ManagerHost managerHost = new CallAtService_ManagerHost();
                managerHost.Show();
            }
        }

        private void 外卖送达ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (IsStudent == true)
            {
                TakeOutOrder_Student student = new TakeOutOrder_Student(Student.StudentID.ToString());
                student.Show();
            }
            else
            {
                TakeOutOrder_Manager manager = new TakeOutOrder_Manager();
                manager.Show();
            }
        }

		private void 跑腿服务ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new TakeOrder().Show();
		}

        private void 宿舍入住ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsStudent == true)
            {
                CheckInService_Student student = new CheckInService_Student();
                student.Show();
            }
            else
            {
                CheckInService_Manager manager = new CheckInService_Manager();
                manager.Show();
            }
        }
    }
}
