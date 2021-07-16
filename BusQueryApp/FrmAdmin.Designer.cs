namespace BusQueryApp
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gvBus = new System.Windows.Forms.DataGridView();
            this.colid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumb = new System.Windows.Forms.TextBox();
            this.txtRoute = new System.Windows.Forms.TextBox();
            this.btnAdminQuit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeletNumb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvBus)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "< 添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除 >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gvBus
            // 
            this.gvBus.AllowUserToAddRows = false;
            this.gvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colid,
            this.colline});
            this.gvBus.Location = new System.Drawing.Point(3, 2);
            this.gvBus.Name = "gvBus";
            this.gvBus.ReadOnly = true;
            this.gvBus.RowTemplate.Height = 23;
            this.gvBus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvBus.Size = new System.Drawing.Size(744, 235);
            this.gvBus.TabIndex = 2;
            // 
            // colid
            // 
            this.colid.HeaderText = "编号";
            this.colid.Name = "colid";
            this.colid.ReadOnly = true;
            this.colid.Width = 54;
            // 
            // colline
            // 
            this.colline.HeaderText = "路线";
            this.colline.Name = "colline";
            this.colline.ReadOnly = true;
            this.colline.Width = 645;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "添加编号信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "添加路线信息：";
            // 
            // txtNumb
            // 
            this.txtNumb.Location = new System.Drawing.Point(216, 265);
            this.txtNumb.Name = "txtNumb";
            this.txtNumb.Size = new System.Drawing.Size(69, 21);
            this.txtNumb.TabIndex = 5;
            // 
            // txtRoute
            // 
            this.txtRoute.Location = new System.Drawing.Point(216, 297);
            this.txtRoute.Multiline = true;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.Size = new System.Drawing.Size(347, 77);
            this.txtRoute.TabIndex = 6;
            // 
            // btnAdminQuit
            // 
            this.btnAdminQuit.Location = new System.Drawing.Point(559, 380);
            this.btnAdminQuit.Name = "btnAdminQuit";
            this.btnAdminQuit.Size = new System.Drawing.Size(75, 57);
            this.btnAdminQuit.TabIndex = 7;
            this.btnAdminQuit.Text = "返回";
            this.btnAdminQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminQuit.UseVisualStyleBackColor = true;
            this.btnAdminQuit.Click += new System.EventHandler(this.btnAdminQuit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "删除信息编号：";
            // 
            // txtDeletNumb
            // 
            this.txtDeletNumb.Location = new System.Drawing.Point(464, 262);
            this.txtDeletNumb.Name = "txtDeletNumb";
            this.txtDeletNumb.Size = new System.Drawing.Size(69, 21);
            this.txtDeletNumb.TabIndex = 9;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(749, 467);
            this.Controls.Add(this.txtDeletNumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdminQuit);
            this.Controls.Add(this.txtRoute);
            this.Controls.Add(this.txtNumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvBus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公交管理系统";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumb;
        private System.Windows.Forms.TextBox txtRoute;
        private System.Windows.Forms.Button btnAdminQuit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeletNumb;
    }
}