namespace DormManagementApp
{
    partial class AddCallAtApplication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDelete = new System.Windows.Forms.Button();
            this.AddOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VisitorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Remarks = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AddDelete
            // 
            this.AddDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDelete.Location = new System.Drawing.Point(256, 294);
            this.AddDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDelete.Name = "AddDelete";
            this.AddDelete.Size = new System.Drawing.Size(109, 36);
            this.AddDelete.TabIndex = 0;
            this.AddDelete.Text = "取消";
            this.AddDelete.UseVisualStyleBackColor = true;
            this.AddDelete.Click += new System.EventHandler(this.AddDelete_Click);
            // 
            // AddOK
            // 
            this.AddOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddOK.Location = new System.Drawing.Point(136, 294);
            this.AddOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOK.Name = "AddOK";
            this.AddOK.Size = new System.Drawing.Size(115, 36);
            this.AddOK.TabIndex = 1;
            this.AddOK.Text = "确认";
            this.AddOK.UseVisualStyleBackColor = true;
            this.AddOK.Click += new System.EventHandler(this.AddOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "来访者姓名：";
            // 
            // VisitorName
            // 
            this.VisitorName.Location = new System.Drawing.Point(137, 39);
            this.VisitorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Size = new System.Drawing.Size(228, 25);
            this.VisitorName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "来访时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "宿舍号：";
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(136, 115);
            this.Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(228, 25);
            this.Room.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "备注：";
            // 
            // Remarks
            // 
            this.Remarks.Location = new System.Drawing.Point(137, 155);
            this.Remarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(228, 114);
            this.Remarks.TabIndex = 10;
            this.Remarks.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(137, 76);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 25);
            this.dateTimePicker.TabIndex = 11;
            // 
            // AddCallAtApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(440, 344);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Remarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VisitorName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddOK);
            this.Controls.Add(this.AddDelete);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddCallAtApplication";
            this.Text = "添加来访申请";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDelete;
        private System.Windows.Forms.Button AddOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VisitorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Remarks;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}