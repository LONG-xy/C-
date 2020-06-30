namespace DormManagementApp
{
    partial class ChangeCallAtApplication_student
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Remarks = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VisitorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOK = new System.Windows.Forms.Button();
            this.AddDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(132, 70);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(228, 25);
            this.dateTimePicker.TabIndex = 21;
            this.dateTimePicker.Value = new System.DateTime(2020, 6, 20, 0, 0, 0, 0);
            // 
            // Remarks
            // 
            this.Remarks.Location = new System.Drawing.Point(132, 149);
            this.Remarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Remarks.Name = "Remarks";
            this.Remarks.Size = new System.Drawing.Size(228, 114);
            this.Remarks.TabIndex = 20;
            this.Remarks.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "备注：";
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(131, 109);
            this.Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(228, 25);
            this.Room.TabIndex = 18;
            this.Room.Text = "404";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "宿舍号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "来访时间：";
            // 
            // VisitorName
            // 
            this.VisitorName.Location = new System.Drawing.Point(132, 32);
            this.VisitorName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Size = new System.Drawing.Size(228, 25);
            this.VisitorName.TabIndex = 15;
            this.VisitorName.Text = "zhang san";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "来访者姓名：";
            // 
            // AddOK
            // 
            this.AddOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddOK.Location = new System.Drawing.Point(127, 280);
            this.AddOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddOK.Name = "AddOK";
            this.AddOK.Size = new System.Drawing.Size(115, 36);
            this.AddOK.TabIndex = 13;
            this.AddOK.Text = "确认";
            this.AddOK.UseVisualStyleBackColor = true;
            this.AddOK.Click += new System.EventHandler(this.AddOK_Click);
            // 
            // AddDelete
            // 
            this.AddDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDelete.Location = new System.Drawing.Point(247, 280);
            this.AddDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDelete.Name = "AddDelete";
            this.AddDelete.Size = new System.Drawing.Size(109, 36);
            this.AddDelete.TabIndex = 12;
            this.AddDelete.Text = "取消";
            this.AddDelete.UseVisualStyleBackColor = true;
            this.AddDelete.Click += new System.EventHandler(this.AddDelete_Click);
            // 
            // ChangeCallAtApplication_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(409, 330);
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
            this.Name = "ChangeCallAtApplication_student";
            this.Text = "修改来访申请";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox Remarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Room;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox VisitorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddOK;
        private System.Windows.Forms.Button AddDelete;
    }
}