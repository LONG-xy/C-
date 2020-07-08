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
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drom d = new drom();
            d.Show();
        }
    }
}
