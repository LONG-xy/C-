using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;

namespace TakeOutManagement
{
	public partial class FClient : Form
	{
		public FClient()
		{
			InitializeComponent();
			TextBox.CheckForIllegalCrossThreadCalls = false;
		}
 
		Socket socketClient = null;
		Thread threadClient = null;

		public const int SendBufferSize = 2 * 1024;
		public const int ReceiveBufferSize = 8 * 1024;

		private void btnConnectToServer_Click(object sender, EventArgs e)
		{
			socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

			
			IPAddress serverIPAddress = IPAddress.Parse(txtIP.Text.Trim());
			int serverPort = int.Parse(txtPort.Text.Trim());
			IPEndPoint endpoint = new IPEndPoint(serverIPAddress, serverPort);
		
			socketClient.Connect(endpoint);
			threadClient = new Thread(RecMsg);
			threadClient.IsBackground = true;

			threadClient.Start();
			txtMsg.AppendText("已与服务端建立连接,可以开始通信...\r\n");
			btnConnectToServer.Enabled = false;
		}


		/// <summary>
		/// 接受服务端发来信息的方法
		/// </summary>
		private void RecMsg()
		{
			while (true) 
			{
				string strRecMsg = null;
				int length = 0;
				byte[] buffer = new byte[SendBufferSize];
				try
				{
					
					length = socketClient.Receive(buffer);
				}
				catch (SocketException ex)
				{
					txtMsg.AppendText("套接字异常消息:" + ex.Message + "\r\n");
					txtMsg.AppendText("服务端已断开连接\r\n");
					break;
				}
				catch (Exception ex)
				{
					txtMsg.AppendText("系统异常消息: " + ex.Message + "\r\n");
					break;
				}
				strRecMsg = Encoding.UTF8.GetString(buffer, 0, length);
				txtMsg.AppendText("服务端在 " + GetCurrentTime() + " 给您发送了:\r\n" + strRecMsg + "\r\n");
			}
		}

		/// <summary>
		/// 发送字符串信息到服务端的方法
		/// </summary>
		private void ClientSendMsg(string sendMsg, byte symbol)
		{
			byte[] arrClientMsg = Encoding.UTF8.GetBytes(sendMsg);

			byte[] arrClientSendMsg = new byte[arrClientMsg.Length + 1];
			arrClientSendMsg[0] = symbol; 
			Buffer.BlockCopy(arrClientMsg, 0, arrClientSendMsg, 1, arrClientMsg.Length);

			socketClient.Send(arrClientSendMsg);
			txtMsg.AppendText("User:" + GetCurrentTime() + "\r\n" + sendMsg + "\r\n");
		}


		private void btnCSend_Click(object sender, EventArgs e)
		{
			ClientSendMsg(txtCMsg.Text, 0);
		}


		private void txtCMsg_KeyDown(object sender, KeyEventArgs e)
		{    
			if (e.KeyCode == Keys.Enter)
			{

				ClientSendMsg(txtCMsg.Text, 0);
			}
		}

		string filePath = null;   
		string fileName = null; 
		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofDialog = new OpenFileDialog();
			if (ofDialog.ShowDialog(this) == DialogResult.OK)
			{
				fileName = ofDialog.SafeFileName; 
				txtFileName.Text = fileName;       
				filePath = ofDialog.FileName;     
			}
		}

		/// <summary>
		/// 发送文件的方法
		/// </summary>
		/// <param name="fileFullPath">文件全路径(包含文件名称)</param>
		private void SendFile(string fileFullPath)
		{
			if (string.IsNullOrEmpty(fileFullPath))
			{
				MessageBox.Show(@"请选择需要发送的文件!");
				return;
			}

		
			long fileLength = new FileInfo(fileFullPath).Length;
			string totalMsg = string.Format("{0}-{1}", fileName, fileLength);
			ClientSendMsg(totalMsg, 2);



			byte[] buffer = new byte[SendBufferSize];

			using (FileStream fs = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read))
			{
				int readLength = 0;
				bool firstRead = true;
				long sentFileLength = 0;
				while ((readLength = fs.Read(buffer, 0, buffer.Length)) > 0 && sentFileLength < fileLength)
				{
					sentFileLength += readLength;
				
					if (firstRead)
					{
						byte[] firstBuffer = new byte[readLength + 1];
						firstBuffer[0] = 1; 
						Buffer.BlockCopy(buffer, 0, firstBuffer, 1, readLength);

						socketClient.Send(firstBuffer, 0, readLength + 1, SocketFlags.None);

						firstRead = false;
						continue;
					}
				
					socketClient.Send(buffer, 0, readLength, SocketFlags.None);
				}
				fs.Close();
			}
			txtMsg.AppendText("User:" + GetCurrentTime() + "\r\n您发送了文件:" + fileName + "\r\n");
		}

	
		private void btnSendFile_Click(object sender, EventArgs e)
		{
			SendFile(filePath);
		}

		/// <summary>
		/// 获取当前系统时间
		/// </summary>
		public DateTime GetCurrentTime()
		{
			DateTime currentTime = new DateTime();
			currentTime = DateTime.Now;
			return currentTime;
		}


		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
