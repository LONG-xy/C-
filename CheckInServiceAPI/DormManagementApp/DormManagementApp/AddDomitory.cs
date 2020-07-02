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
    public partial class AddDomitory : Form
    {
        public AddDomitory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string no = this.textBox1.Text;
            string phone = this.textBox2.Text;
            Domitory domitory = new Domitory()
            {
                DomitoryID = no,
                PhoneNumber = phone
            };

            var result = APIHelper.Post<ApiResult>(WebSetting.GetUrl("Domitory/Add"), new Dictionary<string, object>() { { "DomitoryID", no }, { "PhoneNumber", phone } });

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
