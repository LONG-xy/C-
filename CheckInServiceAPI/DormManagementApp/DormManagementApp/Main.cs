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
    public partial class Main : Form
    {
        private Form form = null;
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        protected override void OnShown(EventArgs e)
        {
            Init();
            StudentMain student = new StudentMain();
            student.MdiParent = this;
            student.StartPosition = FormStartPosition.CenterScreen;
            student.MaximizeBox = false;
            student.Dock = DockStyle.Fill;

            form = student;
            student.Show();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void Student_Click(object sender, EventArgs e)
        {
            Init();
            StudentMain student = new StudentMain();
            student.MdiParent = this;
            student.StartPosition = FormStartPosition.CenterScreen;
            student.MaximizeBox = false;
            student.Dock = DockStyle.Fill;
            form = student;
            student.Show();
        }

        private void Domitory_Click(object sender, EventArgs e)
        {
            DomitoryMain domitory = new DomitoryMain();
            domitory.MdiParent = this;
            domitory.StartPosition = FormStartPosition.CenterScreen;
            domitory.MaximizeBox = false;
            domitory.Dock = DockStyle.Fill;
            Init();
            form = domitory;
            domitory.Show();
        }

       
        private void Init()
        {
            if (form != null)
                form.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
