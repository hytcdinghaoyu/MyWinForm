namespace feiyu
{
    partial class UCFrdList
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNick = new System.Windows.Forms.Label();
            this.lblShuoShuo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(93, 10);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(41, 12);
            this.lblNick.TabIndex = 1;
            this.lblNick.Text = "阿卡利";
            // 
            // lblShuoShuo
            // 
            this.lblShuoShuo.AutoSize = true;
            this.lblShuoShuo.Location = new System.Drawing.Point(93, 46);
            this.lblShuoShuo.Name = "lblShuoShuo";
            this.lblShuoShuo.Size = new System.Drawing.Size(77, 12);
            this.lblShuoShuo.TabIndex = 1;
            this.lblShuoShuo.Text = "奉均衡之命！";
            // 
            // UCFrdList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblShuoShuo);
            this.Controls.Add(this.lblNick);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCFrdList";
            this.Size = new System.Drawing.Size(200, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.Label lblShuoShuo;
    }
}
