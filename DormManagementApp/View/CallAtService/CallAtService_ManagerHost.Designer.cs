namespace DormManagementApp
{
    partial class CallAtService_ManagerHost
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
            this.components = new System.ComponentModel.Container();
            this.CheckButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AllApplicationSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.ApplicationData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllApplicationSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationData)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CheckButton.Location = new System.Drawing.Point(526, 14);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(103, 30);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "查看/修改";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Deletebutton.Location = new System.Drawing.Point(667, 14);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(101, 30);
            this.Deletebutton.TabIndex = 1;
            this.Deletebutton.Text = "删除申请";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ApplicationData);
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 380);
            this.panel1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(234, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(100, 27);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "学号查询";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click_1);
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(12, 16);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(185, 25);
            this.IDtext.TabIndex = 3;
            // 
            // ApplicationData
            // 
            this.ApplicationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApplicationData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplicationData.Location = new System.Drawing.Point(0, 0);
            this.ApplicationData.Name = "ApplicationData";
            this.ApplicationData.ReadOnly = true;
            this.ApplicationData.RowHeadersWidth = 51;
            this.ApplicationData.RowTemplate.Height = 27;
            this.ApplicationData.Size = new System.Drawing.Size(791, 380);
            this.ApplicationData.TabIndex = 0;
            // 
            // CallAtService_ManagerHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 468);
            this.Controls.Add(this.IDtext);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.CheckButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CallAtService_ManagerHost";
            this.Text = "来访申请";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllApplicationSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource AllApplicationSource;
        private System.Windows.Forms.DataGridView ApplicationData;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox IDtext;
    }
}