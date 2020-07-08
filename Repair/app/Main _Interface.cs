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
    public partial class Repair : Form
    {
        public Repair()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Repair_Student r = new Repair_Student();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Repair_Search s = new Repair_Search();
            s.Show();
        }
    }
}
