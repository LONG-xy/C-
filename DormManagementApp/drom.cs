using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class drom : Form
    {
        public drom()
        {
            InitializeComponent();
        }

        private void drom_Load(object sender, EventArgs e)
        {
 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            manage m = new manage("", choose.drom);
            m.Show();
        }
    }
}
