using ErrandService;
using System;
using System.Windows.Forms;

namespace TakeOutManagement
{
    static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TakeOrderForm());
		}
	}
}
