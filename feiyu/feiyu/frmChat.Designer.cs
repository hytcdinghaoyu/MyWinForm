namespace feiyu
{
    partial class frmChat
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
            this.txtTalkMain = new System.Windows.Forms.TextBox();
            this.txtMsgMain = new System.Windows.Forms.TextBox();
            this.picFrdHead = new System.Windows.Forms.PictureBox();
            this.lblFrdNick = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblShuoShuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFrdHead)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTalkMain
            // 
            this.txtTalkMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTalkMain.Location = new System.Drawing.Point(12, 12);
            this.txtTalkMain.Multiline = true;
            this.txtTalkMain.Name = "txtTalkMain";
            this.txtTalkMain.Size = new System.Drawing.Size(436, 318);
            this.txtTalkMain.TabIndex = 0;
            // 
            // txtMsgMain
            // 
            this.txtMsgMain.Location = new System.Drawing.Point(12, 363);
            this.txtMsgMain.Multiline = true;
            this.txtMsgMain.Name = "txtMsgMain";
            this.txtMsgMain.Size = new System.Drawing.Size(435, 46);
            this.txtMsgMain.TabIndex = 1;
            // 
            // picFrdHead
            // 
            this.picFrdHead.Location = new System.Drawing.Point(470, 12);
            this.picFrdHead.Name = "picFrdHead";
            this.picFrdHead.Size = new System.Drawing.Size(130, 130);
            this.picFrdHead.TabIndex = 2;
            this.picFrdHead.TabStop = false;
            // 
            // lblFrdNick
            // 
            this.lblFrdNick.AutoSize = true;
            this.lblFrdNick.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFrdNick.Location = new System.Drawing.Point(478, 159);
            this.lblFrdNick.Name = "lblFrdNick";
            this.lblFrdNick.Size = new System.Drawing.Size(59, 22);
            this.lblFrdNick.TabIndex = 3;
            this.lblFrdNick.Text = "label1";
            this.lblFrdNick.Click += new System.EventHandler(this.lblFrdNick_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(470, 363);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 44);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblShuoShuo
            // 
            this.lblShuoShuo.AutoSize = true;
            this.lblShuoShuo.Location = new System.Drawing.Point(516, 216);
            this.lblShuoShuo.Name = "lblShuoShuo";
            this.lblShuoShuo.Size = new System.Drawing.Size(41, 12);
            this.lblShuoShuo.TabIndex = 5;
            this.lblShuoShuo.Text = "label1";
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 419);
            this.Controls.Add(this.lblShuoShuo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblFrdNick);
            this.Controls.Add(this.picFrdHead);
            this.Controls.Add(this.txtMsgMain);
            this.Controls.Add(this.txtTalkMain);
            this.Name = "frmChat";
            this.Text = "`";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmChat_FormClosing);
            this.Load += new System.EventHandler(this.frmChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFrdHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTalkMain;
        public System.Windows.Forms.TextBox txtMsgMain;
        public System.Windows.Forms.PictureBox picFrdHead;
        public System.Windows.Forms.Label lblFrdNick;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.Label lblShuoShuo;
    }
}