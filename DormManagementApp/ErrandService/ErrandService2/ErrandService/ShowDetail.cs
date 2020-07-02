using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeOutManagement
{
	public partial class ShowDetail : Form
	{
		public Order CurrentOrder { get; set; }

		//构造函数
		public ShowDetail(Order order)
		{
			InitializeComponent();
			//TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
			CurrentOrder = order;
			orderBindingSource.DataSource = CurrentOrder;


			checkedListBox1.SetItemChecked(0, true);
			if (CurrentOrder.OrderState == Order.State.Taken)
			{
				checkedListBox1.SetItemChecked(1, true);
				checkedListBox1.SetItemChecked(2, false);
			}
			if (CurrentOrder.OrderState == Order.State.Fulfilled)
			{
				checkedListBox1.SetItemChecked(1, true);
				checkedListBox1.SetItemChecked(2, true);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("这个不会写");
		}
	}
}
