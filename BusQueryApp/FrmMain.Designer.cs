namespace BusQueryApp
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnGuanli = new System.Windows.Forms.Button();
            this.btnChaxun = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.kongge = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公交路线管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolUserAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.查询QToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.公交路线查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClos = new System.Windows.Forms.Button();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuanli
            // 
            this.btnGuanli.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuanli.BackgroundImage")));
            this.btnGuanli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuanli.Location = new System.Drawing.Point(87, 130);
            this.btnGuanli.Name = "btnGuanli";
            this.btnGuanli.Size = new System.Drawing.Size(125, 272);
            this.btnGuanli.TabIndex = 0;
            this.btnGuanli.UseVisualStyleBackColor = true;
            this.btnGuanli.Click += new System.EventHandler(this.btnGuanli_Click);
            // 
            // btnChaxun
            // 
            this.btnChaxun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChaxun.BackgroundImage")));
            this.btnChaxun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChaxun.Location = new System.Drawing.Point(319, 130);
            this.btnChaxun.Name = "btnChaxun";
            this.btnChaxun.Size = new System.Drawing.Size(125, 272);
            this.btnChaxun.TabIndex = 1;
            this.btnChaxun.UseVisualStyleBackColor = true;
            this.btnChaxun.Click += new System.EventHandler(this.btnChaxun_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tolUserName,
            this.toolStripStatusLabel2,
            this.tolRole,
            this.kongge,
            this.toolStripStatusLabel4,
            this.tolTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 522);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel1.Text = "当前用户：";
            // 
            // tolUserName
            // 
            this.tolUserName.Name = "tolUserName";
            this.tolUserName.Size = new System.Drawing.Size(84, 17);
            this.tolUserName.Text = "lblUserName";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(68, 17);
            this.toolStripStatusLabel2.Text = "用户权限：";
            // 
            // tolRole
            // 
            this.tolRole.Name = "tolRole";
            this.tolRole.Size = new System.Drawing.Size(48, 17);
            this.tolRole.Text = "lblRole";
            // 
            // kongge
            // 
            this.kongge.Name = "kongge";
            this.kongge.Size = new System.Drawing.Size(160, 17);
            this.kongge.Text = "                                      ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel4.Text = "湖北工业职院信智系";
            // 
            // tolTime
            // 
            this.tolTime.Name = "tolTime";
            this.tolTime.Size = new System.Drawing.Size(33, 17);
            this.tolTime.Text = "time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理MToolStripMenuItem,
            this.查询QToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理MToolStripMenuItem
            // 
            this.管理MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公交路线管理ToolStripMenuItem,
            this.toolUserAdmin});
            this.管理MToolStripMenuItem.Name = "管理MToolStripMenuItem";
            this.管理MToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.管理MToolStripMenuItem.Text = "管理（M）";
            // 
            // 公交路线管理ToolStripMenuItem
            // 
            this.公交路线管理ToolStripMenuItem.Name = "公交路线管理ToolStripMenuItem";
            this.公交路线管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.公交路线管理ToolStripMenuItem.Text = "公交路线管理";
            this.公交路线管理ToolStripMenuItem.Click += new System.EventHandler(this.公交路线管理ToolStripMenuItem_Click);
            // 
            // toolUserAdmin
            // 
            this.toolUserAdmin.Name = "toolUserAdmin";
            this.toolUserAdmin.Size = new System.Drawing.Size(180, 22);
            this.toolUserAdmin.Text = "用户管理";
            this.toolUserAdmin.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 查询QToolStripMenuItem
            // 
            this.查询QToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.公交路线查询ToolStripMenuItem});
            this.查询QToolStripMenuItem.Name = "查询QToolStripMenuItem";
            this.查询QToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.查询QToolStripMenuItem.Text = "查询（Q）";
            // 
            // 公交路线查询ToolStripMenuItem
            // 
            this.公交路线查询ToolStripMenuItem.Name = "公交路线查询ToolStripMenuItem";
            this.公交路线查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.公交路线查询ToolStripMenuItem.Text = "公交路线查询";
            this.公交路线查询ToolStripMenuItem.Click += new System.EventHandler(this.公交路线查询ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.退出ToolStripMenuItem.Text = "退出（E）";
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // btnClos
            // 
            this.btnClos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClos.BackgroundImage")));
            this.btnClos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClos.Location = new System.Drawing.Point(551, 130);
            this.btnClos.Name = "btnClos";
            this.btnClos.Size = new System.Drawing.Size(119, 272);
            this.btnClos.TabIndex = 4;
            this.btnClos.UseVisualStyleBackColor = true;
            this.btnClos.Click += new System.EventHandler(this.btnClos_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(793, 544);
            this.Controls.Add(this.btnClos);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnChaxun);
            this.Controls.Add(this.btnGuanli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(809, 582);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公交查询管理系统";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuanli;
        private System.Windows.Forms.Button btnChaxun;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tolUserName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tolRole;
        private System.Windows.Forms.ToolStripStatusLabel kongge;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tolTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公交路线管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询QToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 公交路线查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.Button btnClos;
        private System.Windows.Forms.ToolStripMenuItem toolUserAdmin;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}