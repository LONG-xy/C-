using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace ChatServer
{
    public partial class FServer : Form
    {
        public FServer()
        {
            InitializeComponent();
           
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
       
        Thread threadWatch = null;
        Socket socketWatch = null;

        public const int SendBufferSize = 2 * 1024;
        public const int ReceiveBufferSize = 8 * 1024;

        private void btnStartService_Click(object sender, EventArgs e)
        {
            
            socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            IPAddress ipAddress = GetLocalIPv4Address();
            lblIP.Text = ipAddress.ToString();
           
            int port = 6666;
            lblPort.Text = port.ToString();        
            IPEndPoint endpoint = new IPEndPoint(ipAddress, port);
            socketWatch.Bind(endpoint);

            socketWatch.Listen(20);

            threadWatch = new Thread(WatchConnecting);
         
            threadWatch.IsBackground = true;
            threadWatch.Start();
            txtMsg.AppendText("服务器已经启动,开始监听客户端传来的信息!" + "\r\n");
            btnStartService.Enabled = false;
        }

        /// <summary>
        /// 获取本地IPv4地址
        /// </summary>
        /// <returns>本地IPv4地址</returns>
        public IPAddress GetLocalIPv4Address()
        {
            IPAddress localIPv4 = null;

            IPAddress[] ipAddressList = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ipAddress in ipAddressList)
            {
                if (ipAddress.AddressFamily == AddressFamily.InterNetwork) //AddressFamily.InterNetwork表示IPv4 
                {
                    localIPv4 = ipAddress;
                }
                else
                    continue;
            }
            return localIPv4;
        }

        //用于保存所有通信客户端的Socket
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

     
        Socket socConnection = null;
        string clientName = null; 
        IPAddress clientIP; 
        int clientPort; 
        /// <summary>
        /// 持续不断监听客户端发来的请求, 用于不断获取客户端发送过来的连续数据信息
        /// </summary>
        private void WatchConnecting()
        {
            while (true)
            {
                try
                {
                    socConnection = socketWatch.Accept();
                }
                catch (Exception ex)
                {
                    txtMsg.AppendText(ex.Message);
                    break;
                }
            
                clientIP = (socConnection.RemoteEndPoint as IPEndPoint).Address;
               
                clientPort = (socConnection.RemoteEndPoint as IPEndPoint).Port;
          
                clientName = "IP: " + clientIP +" Port: "+ clientPort;
                lstClients.Items.Add(clientName); 
                dicSocket.Add(clientName, socConnection); 

              
                ParameterizedThreadStart pts = new ParameterizedThreadStart(ServerRecMsg);
                Thread thread = new Thread(pts);
                thread.IsBackground = true;
               
                thread.Start(socConnection);
                txtMsg.AppendText("IP: " + clientIP + " Port: " + clientPort + " 的客户端与您连接成功,现在你们可以开始通信了...\r\n");
            }
        }

        /// <summary>
        /// 发送信息到客户端的方法
        /// </summary>
        /// <param name="sendMsg">发送的字符串信息</param>
        private void ServerSendMsg(string sendMsg)
        {
            sendMsg = txtSendMsg.Text.Trim();
        
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(sendMsg);
      
            if (!string.IsNullOrEmpty(lstClients.Text.Trim())) 
            {
                dicSocket[lstClients.Text.Trim()].Send(arrSendMsg);

                txtMsg.AppendText("您在 " + GetCurrentTime() + " 向 IP: " + clientIP + " Port: " + clientPort + " 的客户端发送了:\r\n" + sendMsg + "\r\n");
            }
            else
            {
               
                for (int i = 0; i < lstClients.Items.Count; i++)
                {
                    dicSocket[lstClients.Items[i].ToString()].Send(arrSendMsg);
                }
                txtMsg.AppendText("您在 " + GetCurrentTime() + " 群发了信息:\r\n" + sendMsg + " \r\n");
            }
        }

        string strSRecMsg = null;
        /// <summary>
        /// 接收客户端发来的信息
        /// </summary>
        private void ServerRecMsg(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;

            long fileLength = 0;
            while (true)
            {
                int firstReceived = 0;
                byte[] buffer = new byte[ReceiveBufferSize];
                try
                {
          
                    if (socketServer != null) firstReceived = socketServer.Receive(buffer);

                    if (firstReceived > 0) 
                    {
                        if (buffer[0] == 0) 
                        {
                            strSRecMsg = Encoding.UTF8.GetString(buffer, 1, firstReceived - 1);
                            txtMsg.AppendText("SoFlash:" + GetCurrentTime() + "\r\n" + strSRecMsg + "\r\n");
                        }
                        if (buffer[0] == 2)
                        {
                            string fileNameWithLength = Encoding.UTF8.GetString(buffer, 1, firstReceived - 1);
                            strSRecMsg = fileNameWithLength.Split('-').First(); //文件名
                            fileLength = Convert.ToInt64(fileNameWithLength.Split('-').Last());//文件长度
                        }
                        if (buffer[0] == 1)//1为文件
                        {
                            string fileNameSuffix = strSRecMsg.Substring(strSRecMsg.LastIndexOf('.')); //文件后缀
                            SaveFileDialog sfDialog = new SaveFileDialog()
                            {
                                Filter = "(*" + fileNameSuffix + ")|*" + fileNameSuffix + "", //文件类型
                                FileName = strSRecMsg
                            };

                            //如果点击了对话框中的保存文件按钮 
                            if (sfDialog.ShowDialog(this) == DialogResult.OK)
                            {
                                string savePath = sfDialog.FileName; //获取文件的全路径
                                //保存文件
                                int received = 0;
                                long receivedTotalFilelength = 0;
                                bool firstWrite = true;
                                using (FileStream fs = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                                {
                                    while (receivedTotalFilelength < fileLength) //之后收到的文件字节数组
                                    {
                                        if (firstWrite)
                                        {
                                            fs.Write(buffer, 1, firstReceived - 1); //第一次收到的文件字节数组 需要移除标识符1 后写入文件
                                            fs.Flush();

                                            receivedTotalFilelength += firstReceived - 1;

                                            firstWrite = false;
                                            continue;
                                        }
                                        received = socketServer.Receive(buffer); 
                                        fs.Write(buffer, 0, received);
                                        fs.Flush();

                                        receivedTotalFilelength += received;
                                    }
                                    fs.Close();
                                }

                                string fName = savePath.Substring(savePath.LastIndexOf("\\") + 1); 
                                string fPath = savePath.Substring(0, savePath.LastIndexOf("\\")); 
                                txtMsg.AppendText("User:" + GetCurrentTime() + "\r\n您成功接收了文件" + fName + "\r\n保存路径为:" + fPath + "\r\n");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    txtMsg.AppendText("系统异常消息:" + ex.Message);
                    break;
                }
            }
        }
		
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            ServerSendMsg(txtSendMsg.Text);
        }


        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ServerSendMsg(txtSendMsg.Text);
            }
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
		
        private void btnClearSelectedState_Click(object sender, EventArgs e)
        {
            lstClients.SelectedItem = null;
        }
    }
}
