namespace DormManagementApp
{
    partial class CallAtService_StudentHost
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
            this.AddApplication = new System.Windows.Forms.Button();
            this.ChangeApplication = new System.Windows.Forms.Button();
            this.DeleteApplication = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.ApplicationData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationData)).BeginInit();
            this.SuspendLayout();
            // 
            // AddApplication
            // 
            this.AddApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddApplication.Location = new System.Drawing.Point(476, 30);
            this.AddApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddApplication.Name = "AddApplication";
            this.AddApplication.Size = new System.Drawing.Size(88, 30);
            this.AddApplication.TabIndex = 0;
            this.AddApplication.Text = "添加来访";
            this.AddApplication.UseVisualStyleBackColor = true;
            this.AddApplication.Click += new System.EventHandler(this.AddCallAtApplication_Click);
            // 
            // ChangeApplication
            // 
            this.ChangeApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeApplication.Location = new System.Drawing.Point(569, 30);
            this.ChangeApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChangeApplication.Name = "ChangeApplication";
            this.ChangeApplication.Size = new System.Drawing.Size(88, 30);
            this.ChangeApplication.TabIndex = 1;
            this.ChangeApplication.Text = "修改来访";
            this.ChangeApplication.UseVisualStyleBackColor = true;
            this.ChangeApplication.Click += new System.EventHandler(this.ChangeCallAtApplication_Click);
            // 
            // DeleteApplication
            // 
            this.DeleteApplication.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DeleteApplication.Location = new System.Drawing.Point(663, 30);
            this.DeleteApplication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteApplication.Name = "DeleteApplication";
            this.DeleteApplication.Size = new System.Drawing.Size(88, 30);
            this.DeleteApplication.TabIndex = 2;
            this.DeleteApplication.Text = "删除来访";
            this.DeleteApplication.UseVisualStyleBackColor = true;
            this.DeleteApplication.Click += new System.EventHandler(this.DeleteApplication_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 25);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(244, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApplicationData
            // 
            this.ApplicationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationData.Location = new System.Drawing.Point(12, 87);
            this.ApplicationData.Name = "ApplicationData";
            this.ApplicationData.ReadOnly = true;
            this.ApplicationData.RowHeadersWidth = 51;
            this.ApplicationData.RowTemplate.Height = 27;
            this.ApplicationData.Size = new System.Drawing.Size(736, 352);
            this.ApplicationData.TabIndex = 7;
            // 
            // CallAtService_StudentHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(764, 465);
            this.Controls.Add(this.ApplicationData);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DeleteApplication);
            this.Controls.Add(this.ChangeApplication);
            this.Controls.Add(this.AddApplication);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CallAtService_StudentHost";
            this.Text = "来访申请";
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddApplication;
        private System.Windows.Forms.Button ChangeApplication;
        private System.Windows.Forms.Button DeleteApplication;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView ApplicationData;
    }
}