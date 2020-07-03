namespace TakeOutManagement
{
	partial class FClient
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnSendFile = new System.Windows.Forms.Button();
			this.txtCMsg = new System.Windows.Forms.TextBox();
			this.btnCSend = new System.Windows.Forms.Button();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.btnConnectToServer = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Location = new System.Drawing.Point(412, 424);
			this.btnSelectFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(100, 29);
			this.btnSelectFile.TabIndex = 45;
			this.btnSelectFile.Text = "选择文件";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.Location = new System.Drawing.Point(16, 424);
			this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(387, 25);
			this.txtFileName.TabIndex = 44;
			// 
			// btnSendFile
			// 
			this.btnSendFile.Location = new System.Drawing.Point(520, 424);
			this.btnSendFile.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSendFile.Name = "btnSendFile";
			this.btnSendFile.Size = new System.Drawing.Size(100, 29);
			this.btnSendFile.TabIndex = 43;
			this.btnSendFile.Text = "发送文件";
			this.btnSendFile.UseVisualStyleBackColor = true;
			this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
			// 
			// txtCMsg
			// 
			this.txtCMsg.Location = new System.Drawing.Point(16, 369);
			this.txtCMsg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtCMsg.Multiline = true;
			this.txtCMsg.Name = "txtCMsg";
			this.txtCMsg.Size = new System.Drawing.Size(495, 25);
			this.txtCMsg.TabIndex = 40;
			this.txtCMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCMsg_KeyDown);
			// 
			// btnCSend
			// 
			this.btnCSend.Location = new System.Drawing.Point(520, 368);
			this.btnCSend.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCSend.Name = "btnCSend";
			this.btnCSend.Size = new System.Drawing.Size(100, 29);
			this.btnCSend.TabIndex = 38;
			this.btnCSend.Text = "发送";
			this.btnCSend.UseVisualStyleBackColor = true;
			this.btnCSend.Click += new System.EventHandler(this.btnCSend_Click);
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(16, 152);
			this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtMsg.Multiline = true;
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMsg.Size = new System.Drawing.Size(603, 192);
			this.txtMsg.TabIndex = 37;
			// 
			// btnConnectToServer
			// 
			this.btnConnectToServer.Location = new System.Drawing.Point(356, 28);
			this.btnConnectToServer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnConnectToServer.Name = "btnConnectToServer";
			this.btnConnectToServer.Size = new System.Drawing.Size(100, 29);
			this.btnConnectToServer.TabIndex = 36;
			this.btnConnectToServer.Text = "连接服务端";
			this.btnConnectToServer.UseVisualStyleBackColor = true;
			this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(475, 28);
			this.btnExit.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(112, 28);
			this.btnExit.TabIndex = 48;
			this.btnExit.Text = "关闭客户端";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(261, 29);
			this.txtPort.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(63, 25);
			this.txtPort.TabIndex = 3;
			this.txtPort.Text = "6666";
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(52, 29);
			this.txtIP.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(133, 25);
			this.txtIP.TabIndex = 2;
			this.txtIP.Text = "172.20.10.7";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(204, 35);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 15);
			this.label6.TabIndex = 1;
			this.label6.Text = "Port: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 34);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "IP: ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 124);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 15);
			this.label1.TabIndex = 50;
			this.label1.Text = "聊天内容:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txtIP);
			this.groupBox1.Controls.Add(this.btnConnectToServer);
			this.groupBox1.Location = new System.Drawing.Point(16, 21);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(604, 79);
			this.groupBox1.TabIndex = 51;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "服务器";
			// 
			// FClient
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 482);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSelectFile);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnSendFile);
			this.Controls.Add(this.txtCMsg);
			this.Controls.Add(this.btnCSend);
			this.Controls.Add(this.txtMsg);
			this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.Name = "FClient";
			this.Text = "客户端";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button btnSendFile;
		private System.Windows.Forms.TextBox txtCMsg;
		private System.Windows.Forms.Button btnCSend;
		private System.Windows.Forms.TextBox txtMsg;
		private System.Windows.Forms.Button btnConnectToServer;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

