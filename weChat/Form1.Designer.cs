namespace weChat
{
    partial class frmMain
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtRevMsg = new System.Windows.Forms.TextBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOnline = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(222, 323);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(12, 23);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(118, 21);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "255.255.255.255";
            // 
            // txtRevMsg
            // 
            this.txtRevMsg.Location = new System.Drawing.Point(13, 76);
            this.txtRevMsg.Multiline = true;
            this.txtRevMsg.Name = "txtRevMsg";
            this.txtRevMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRevMsg.Size = new System.Drawing.Size(284, 193);
            this.txtRevMsg.TabIndex = 2;
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(13, 284);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(284, 21);
            this.txtSendMsg.TabIndex = 3;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(222, 23);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(75, 21);
            this.txtNick.TabIndex = 4;
            this.txtNick.Text = "dhy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "昵称：";
            // 
            // txtOnline
            // 
            this.txtOnline.Location = new System.Drawing.Point(324, 14);
            this.txtOnline.Multiline = true;
            this.txtOnline.Name = "txtOnline";
            this.txtOnline.Size = new System.Drawing.Size(96, 280);
            this.txtOnline.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(222, 47);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 358);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtOnline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.txtRevMsg);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.btnSend);
            this.Name = "frmMain";
            this.Text = "即时聊天";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtRevMsg;
        private System.Windows.Forms.TextBox txtSendMsg;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOnline;
        private System.Windows.Forms.Button btnLogin;
    }
}

