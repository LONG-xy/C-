using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
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
    }
}
