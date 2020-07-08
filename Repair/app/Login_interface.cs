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
            Repair s = new Repair();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drom d = new drom();
            d.Show();
        }

        private void select_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
