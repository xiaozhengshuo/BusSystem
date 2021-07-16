namespace BusQueryApp
{
    partial class FrmUserAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserAdmin));
            this.dagvall = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClousUser = new System.Windows.Forms.TextBox();
            this.btnClou = new System.Windows.Forms.Button();
            this.btnfanhui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dagvall)).BeginInit();
            this.SuspendLayout();
            // 
            // dagvall
            // 
            this.dagvall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dagvall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUsername,
            this.colpwd,
            this.colRore,
            this.colname,
            this.colphone});
            this.dagvall.Location = new System.Drawing.Point(1, -3);
            this.dagvall.Name = "dagvall";
            this.dagvall.RowTemplate.Height = 23;
            this.dagvall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dagvall.Size = new System.Drawing.Size(597, 165);
            this.dagvall.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "编号";
            this.colId.Name = "colId";
            this.colId.Width = 60;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "用户名";
            this.colUsername.Name = "colUsername";
            // 
            // colpwd
            // 
            this.colpwd.HeaderText = "密码";
            this.colpwd.Name = "colpwd";
            // 
            // colRore
            // 
            this.colRore.HeaderText = "用户角色";
            this.colRore.Name = "colRore";
            // 
            // colname
            // 
            this.colname.HeaderText = "姓名";
            this.colname.Name = "colname";
            // 
            // colphone
            // 
            this.colphone.HeaderText = "电话";
            this.colphone.Name = "colphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "删除用户编号：";
            // 
            // txtClousUser
            // 
            this.txtClousUser.Location = new System.Drawing.Point(230, 200);
            this.txtClousUser.Name = "txtClousUser";
            this.txtClousUser.Size = new System.Drawing.Size(100, 21);
            this.txtClousUser.TabIndex = 2;
            // 
            // btnClou
            // 
            this.btnClou.Location = new System.Drawing.Point(369, 198);
            this.btnClou.Name = "btnClou";
            this.btnClou.Size = new System.Drawing.Size(75, 23);
            this.btnClou.TabIndex = 3;
            this.btnClou.Text = "删除";
            this.btnClou.UseVisualStyleBackColor = true;
            this.btnClou.Click += new System.EventHandler(this.btnClou_Click);
            // 
            // btnfanhui
            // 
            this.btnfanhui.Location = new System.Drawing.Point(369, 244);
            this.btnfanhui.Name = "btnfanhui";
            this.btnfanhui.Size = new System.Drawing.Size(75, 23);
            this.btnfanhui.TabIndex = 4;
            this.btnfanhui.Text = "返回";
            this.btnfanhui.UseVisualStyleBackColor = true;
            this.btnfanhui.Click += new System.EventHandler(this.btnfanhui_Click);
            // 
            // FrmUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 289);
            this.Controls.Add(this.btnfanhui);
            this.Controls.Add(this.btnClou);
            this.Controls.Add(this.txtClousUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dagvall);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserAdmin";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmUserAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dagvall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dagvall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClousUser;
        private System.Windows.Forms.Button btnClou;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colphone;
        private System.Windows.Forms.Button btnfanhui;
    }
}