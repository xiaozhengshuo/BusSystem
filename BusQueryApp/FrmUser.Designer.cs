namespace BusQueryApp
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQnumber = new System.Windows.Forms.TextBox();
            this.txtLine01 = new System.Windows.Forms.TextBox();
            this.btnQ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQjieguo = new System.Windows.Forms.TextBox();
            this.btnfanhui = new System.Windows.Forms.Button();
            this.benQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLine02 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询车次：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "查询线路：";
            // 
            // txtQnumber
            // 
            this.txtQnumber.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtQnumber.Location = new System.Drawing.Point(85, 111);
            this.txtQnumber.Name = "txtQnumber";
            this.txtQnumber.Size = new System.Drawing.Size(179, 21);
            this.txtQnumber.TabIndex = 2;
            this.txtQnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQnumber.Click += new System.EventHandler(this.txtQnumber_Click);
            // 
            // txtLine01
            // 
            this.txtLine01.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtLine01.Location = new System.Drawing.Point(84, 148);
            this.txtLine01.Name = "txtLine01";
            this.txtLine01.Size = new System.Drawing.Size(70, 21);
            this.txtLine01.TabIndex = 3;
            this.txtLine01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLine01.Click += new System.EventHandler(this.txtLine01_Click);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(15, 182);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(249, 58);
            this.btnQ.TabIndex = 4;
            this.btnQ.Text = "查询";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnQ_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "查询结果：";
            // 
            // txtQjieguo
            // 
            this.txtQjieguo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQjieguo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQjieguo.Location = new System.Drawing.Point(17, 279);
            this.txtQjieguo.Multiline = true;
            this.txtQjieguo.Name = "txtQjieguo";
            this.txtQjieguo.ReadOnly = true;
            this.txtQjieguo.Size = new System.Drawing.Size(247, 185);
            this.txtQjieguo.TabIndex = 6;
            // 
            // btnfanhui
            // 
            this.btnfanhui.Location = new System.Drawing.Point(37, 485);
            this.btnfanhui.Name = "btnfanhui";
            this.btnfanhui.Size = new System.Drawing.Size(75, 23);
            this.btnfanhui.TabIndex = 7;
            this.btnfanhui.Text = "返回";
            this.btnfanhui.UseVisualStyleBackColor = true;
            this.btnfanhui.Click += new System.EventHandler(this.btnfanhui_Click);
            // 
            // benQuit
            // 
            this.benQuit.Location = new System.Drawing.Point(161, 485);
            this.benQuit.Name = "benQuit";
            this.benQuit.Size = new System.Drawing.Size(75, 23);
            this.benQuit.TabIndex = 8;
            this.benQuit.Text = "退出";
            this.benQuit.UseVisualStyleBackColor = true;
            this.benQuit.Click += new System.EventHandler(this.benQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 94);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "至";
            // 
            // txtLine02
            // 
            this.txtLine02.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtLine02.Location = new System.Drawing.Point(194, 147);
            this.txtLine02.Name = "txtLine02";
            this.txtLine02.Size = new System.Drawing.Size(70, 21);
            this.txtLine02.TabIndex = 11;
            this.txtLine02.Click += new System.EventHandler(this.txtLine02_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(276, 531);
            this.Controls.Add(this.txtLine02);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.benQuit);
            this.Controls.Add(this.btnfanhui);
            this.Controls.Add(this.txtQjieguo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnQ);
            this.Controls.Add(this.txtLine01);
            this.Controls.Add(this.txtQnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "公交查询";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQnumber;
        private System.Windows.Forms.TextBox txtLine01;
        private System.Windows.Forms.Button btnQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQjieguo;
        private System.Windows.Forms.Button btnfanhui;
        private System.Windows.Forms.Button benQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLine02;
    }
}