namespace DormManagementApp
{
    partial class student
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.报修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.回乡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来访ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.宿舍入住ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外卖送达ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跑腿服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.报修ToolStripMenuItem,
            this.回乡ToolStripMenuItem,
            this.来访ToolStripMenuItem,
            this.宿舍入住ToolStripMenuItem,
            this.外卖送达ToolStripMenuItem,
            this.跑腿服务ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(528, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 报修ToolStripMenuItem
            // 
            this.报修ToolStripMenuItem.Name = "报修ToolStripMenuItem";
            this.报修ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报修ToolStripMenuItem.Text = "报修";
            // 
            // 回乡ToolStripMenuItem
            // 
            this.回乡ToolStripMenuItem.Name = "回乡ToolStripMenuItem";
            this.回乡ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.回乡ToolStripMenuItem.Text = "回乡";
            // 
            // 来访ToolStripMenuItem
            // 
            this.来访ToolStripMenuItem.Name = "来访ToolStripMenuItem";
            this.来访ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.来访ToolStripMenuItem.Text = "来访";
            this.来访ToolStripMenuItem.Click += new System.EventHandler(this.来访ToolStripMenuItem_Click);
            // 
            // 宿舍入住ToolStripMenuItem
            // 
            this.宿舍入住ToolStripMenuItem.Name = "宿舍入住ToolStripMenuItem";
            this.宿舍入住ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.宿舍入住ToolStripMenuItem.Text = "宿舍入住";
            this.宿舍入住ToolStripMenuItem.Click += new System.EventHandler(this.宿舍入住ToolStripMenuItem_Click);
            // 
            // 外卖送达ToolStripMenuItem
            // 
            this.外卖送达ToolStripMenuItem.Name = "外卖送达ToolStripMenuItem";
            this.外卖送达ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.外卖送达ToolStripMenuItem.Text = "外卖送达";
            this.外卖送达ToolStripMenuItem.Click += new System.EventHandler(this.外卖送达ToolStripMenuItem_Click);
            // 
            // 跑腿服务ToolStripMenuItem
            // 
            this.跑腿服务ToolStripMenuItem.Name = "跑腿服务ToolStripMenuItem";
            this.跑腿服务ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.跑腿服务ToolStripMenuItem.Text = "跑腿服务";
            this.跑腿服务ToolStripMenuItem.Click += new System.EventHandler(this.跑腿服务ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "欢迎使用学生宿舍管理系统";
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::app.Properties.Resources.fcfe44a61a01f07e7ba1288c73e8c561;
            this.ClientSize = new System.Drawing.Size(528, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "student";
            this.Text = "学生宿舍管理系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 报修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 回乡ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 来访ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 宿舍入住ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外卖送达ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跑腿服务ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

