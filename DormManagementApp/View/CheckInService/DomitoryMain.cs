using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace DormManagementApp
{
    public partial class DomitoryMain : Form
    {
        public DomitoryMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;//高度
            this.Location = new Point((xWidth - Width) / 2, (yHeight - Height) / 2);
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDomitory addDomitory = new AddDomitory();
            addDomitory.StartPosition = FormStartPosition.CenterScreen;
            if (addDomitory.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("添加宿舍成功");
                RefreshData();
            }
        }

        private void RefreshData()
        {
            string no = this.textBox1.Text;
            string phone = this.textBox2.Text;

            List<Domitory> list = new List<Domitory>();
            var result = APIHelper.Get<ApiResult<List<Domitory>>>(WebSetting.GetUrl("Domitory/List"),
                new Dictionary<string, object>()
                {
                    { "Id",no},
                    { "Phone",phone},
                });

            if (result.Code == 0)
                list = result.Data;
            else
                MessageBox.Show(result.Msg);

            this.dataGridView1.DataSource = list;
        }
    }
}
