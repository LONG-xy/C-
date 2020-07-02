using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormManagementApp
{
	public class User
	{
		private string userName;
		private uint schoolNumber;
		private uint telNumber;

		public string UserName { get => userName; set => userName = value; }
		public uint SchoolNumber { get => schoolNumber; set => schoolNumber = value; }
		public uint TelNumber { get => telNumber; set => telNumber = value; }

		public User(string name,uint sNum,uint telNum) {
			UserName = name;
			SchoolNumber = sNum;
			TelNumber = telNum;
		}
	}
}
