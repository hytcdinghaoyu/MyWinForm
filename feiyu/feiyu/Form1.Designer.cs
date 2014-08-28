namespace feiyu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picHeadImage = new System.Windows.Forms.PictureBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.labShuoShuo = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnFrdList = new System.Windows.Forms.Panel();
            this.imgLiHead = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeadImage
            // 
            this.picHeadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeadImage.BackgroundImage")));
            this.picHeadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHeadImage.Location = new System.Drawing.Point(12, 12);
            this.picHeadImage.Name = "picHeadImage";
            this.picHeadImage.Size = new System.Drawing.Size(60, 60);
            this.picHeadImage.TabIndex = 0;
            this.picHeadImage.TabStop = false;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(87, 12);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(62, 21);
            this.txtNick.TabIndex = 1;
            this.txtNick.Text = "小跳蚤";
            // 
            // labShuoShuo
            // 
            this.labShuoShuo.AutoSize = true;
            this.labShuoShuo.Location = new System.Drawing.Point(85, 49);
            this.labShuoShuo.Name = "labShuoShuo";
            this.labShuoShuo.Size = new System.Drawing.Size(65, 12);
            this.labShuoShuo.TabIndex = 2;
            this.labShuoShuo.Text = "奉均衡之命";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(155, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnFrdList
            // 
            this.pnFrdList.AutoScroll = true;
            this.pnFrdList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFrdList.Location = new System.Drawing.Point(10, 78);
            this.pnFrdList.Name = "pnFrdList";
            this.pnFrdList.Size = new System.Drawing.Size(220, 432);
            this.pnFrdList.TabIndex = 4;
            // 
            // imgLiHead
            // 
            this.imgLiHead.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLiHead.ImageStream")));
            this.imgLiHead.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLiHead.Images.SetKeyName(0, "Ahri_Square_0.png");
            this.imgLiHead.Images.SetKeyName(1, "Akali_Square_0.png");
            this.imgLiHead.Images.SetKeyName(2, "akl.jpg");
            this.imgLiHead.Images.SetKeyName(3, "Alistar_Square_0.png");
            this.imgLiHead.Images.SetKeyName(4, "Amumu_Square_0.png");
            this.imgLiHead.Images.SetKeyName(5, "Anivia_Square_0.png");
            this.imgLiHead.Images.SetKeyName(6, "Annie_Square_0.png");
            this.imgLiHead.Images.SetKeyName(7, "Ashe_Square_0.png");
            this.imgLiHead.Images.SetKeyName(8, "Blitzcrank_Square_0.png");
            this.imgLiHead.Images.SetKeyName(9, "Brand_Square_0.png");
            this.imgLiHead.Images.SetKeyName(10, "Caitlyn_Square_0.png");
            this.imgLiHead.Images.SetKeyName(11, "Cassiopeia_Square_0.png");
            this.imgLiHead.Images.SetKeyName(12, "Chogath_Square_0.png");
            this.imgLiHead.Images.SetKeyName(13, "Corki_Square_0.png");
            this.imgLiHead.Images.SetKeyName(14, "Darius_Square_0.png");
            this.imgLiHead.Images.SetKeyName(15, "Diana_Square_0.png");
            this.imgLiHead.Images.SetKeyName(16, "Draven_Square_0.png");
            this.imgLiHead.Images.SetKeyName(17, "DrMundo_Square_0.png");
            this.imgLiHead.Images.SetKeyName(18, "Evelynn_Square_0.png");
            this.imgLiHead.Images.SetKeyName(19, "Ezreal_Square_0.png");
            this.imgLiHead.Images.SetKeyName(20, "Fiddlesticks_Square_0.png");
            this.imgLiHead.Images.SetKeyName(21, "Fiora_Square_0.png");
            this.imgLiHead.Images.SetKeyName(22, "Fizz_square_0.png");
            this.imgLiHead.Images.SetKeyName(23, "Galio_Square_0.png");
            this.imgLiHead.Images.SetKeyName(24, "Gangplank_Square_0.png");
            this.imgLiHead.Images.SetKeyName(25, "Garen_Square_0.png");
            this.imgLiHead.Images.SetKeyName(26, "Gragas_Square_0.png");
            this.imgLiHead.Images.SetKeyName(27, "Graves_Square_0.png");
            this.imgLiHead.Images.SetKeyName(28, "Hecarim_Square_0.png");
            this.imgLiHead.Images.SetKeyName(29, "Heimerdinger_Square_0.png");
            this.imgLiHead.Images.SetKeyName(30, "Irelia_Square_0.png");
            this.imgLiHead.Images.SetKeyName(31, "Janna_Square_0.png");
            this.imgLiHead.Images.SetKeyName(32, "JarvanIV_Square_0.png");
            this.imgLiHead.Images.SetKeyName(33, "Jax_Square_0.png");
            this.imgLiHead.Images.SetKeyName(34, "Jayce_Square_0.png");
            this.imgLiHead.Images.SetKeyName(35, "Karma_Square_0.png");
            this.imgLiHead.Images.SetKeyName(36, "Karthus_Square_0.png");
            this.imgLiHead.Images.SetKeyName(37, "Kassadin_Square_0.png");
            this.imgLiHead.Images.SetKeyName(38, "Katarina_Square_0.png");
            this.imgLiHead.Images.SetKeyName(39, "Kayle_Square_0.png");
            this.imgLiHead.Images.SetKeyName(40, "Kennen_Square_0.png");
            this.imgLiHead.Images.SetKeyName(41, "KogMaw_Square_0.png");
            this.imgLiHead.Images.SetKeyName(42, "Leblanc_Square_0.png");
            this.imgLiHead.Images.SetKeyName(43, "LeeSin_Square_0.png");
            this.imgLiHead.Images.SetKeyName(44, "Leona_Square_0.png");
            this.imgLiHead.Images.SetKeyName(45, "Lulu_Square_0.png");
            this.imgLiHead.Images.SetKeyName(46, "Lux_Square_0.png");
            this.imgLiHead.Images.SetKeyName(47, "Malphite_Square_0.png");
            this.imgLiHead.Images.SetKeyName(48, "Malzahar_Square_0.png");
            this.imgLiHead.Images.SetKeyName(49, "Maokai_Square_0.png");
            this.imgLiHead.Images.SetKeyName(50, "MasterYi_Square_0.png");
            this.imgLiHead.Images.SetKeyName(51, "MissFortune_Square_0.png");
            this.imgLiHead.Images.SetKeyName(52, "MonkeyKing_Square_0.png");
            this.imgLiHead.Images.SetKeyName(53, "Mordekaiser_Square_0.png");
            this.imgLiHead.Images.SetKeyName(54, "Morgana_Square_0.png");
            this.imgLiHead.Images.SetKeyName(55, "Nasus_Square_0.png");
            this.imgLiHead.Images.SetKeyName(56, "Nautilus_Square_0.png");
            this.imgLiHead.Images.SetKeyName(57, "Nidalee_Square_0.png");
            this.imgLiHead.Images.SetKeyName(58, "Nocturne_Square_0.png");
            this.imgLiHead.Images.SetKeyName(59, "Nunu_Square_0.png");
            this.imgLiHead.Images.SetKeyName(60, "Olaf_Square_0.png");
            this.imgLiHead.Images.SetKeyName(61, "Orianna_Square_0.png");
            this.imgLiHead.Images.SetKeyName(62, "Pantheon_Square_0.png");
            this.imgLiHead.Images.SetKeyName(63, "Poppy_Square_0.png");
            this.imgLiHead.Images.SetKeyName(64, "Rammus_Square_0.png");
            this.imgLiHead.Images.SetKeyName(65, "Renekton_Square_0.png");
            this.imgLiHead.Images.SetKeyName(66, "Rengar_Square_0.png");
            this.imgLiHead.Images.SetKeyName(67, "Riven_Square_0.png");
            this.imgLiHead.Images.SetKeyName(68, "Rumble_Square_0.png");
            this.imgLiHead.Images.SetKeyName(69, "Ryze_Square_0.png");
            this.imgLiHead.Images.SetKeyName(70, "Sejuani_Square_0.png");
            this.imgLiHead.Images.SetKeyName(71, "Shaco_Square_0.png");
            this.imgLiHead.Images.SetKeyName(72, "Shen_Square_0.png");
            this.imgLiHead.Images.SetKeyName(73, "Shyvana_Square_0.png");
            this.imgLiHead.Images.SetKeyName(74, "Singed_Square_0.png");
            this.imgLiHead.Images.SetKeyName(75, "Sion_Square_0.png");
            this.imgLiHead.Images.SetKeyName(76, "Sivir_Square_0.png");
            this.imgLiHead.Images.SetKeyName(77, "Skarner_Square_0.png");
            this.imgLiHead.Images.SetKeyName(78, "Sona_Square_0.png");
            this.imgLiHead.Images.SetKeyName(79, "Soraka_Square_0.png");
            this.imgLiHead.Images.SetKeyName(80, "Swain_Square_0.png");
            this.imgLiHead.Images.SetKeyName(81, "Syndra_Square_0.png");
            this.imgLiHead.Images.SetKeyName(82, "Talon_Square_0.png");
            this.imgLiHead.Images.SetKeyName(83, "Taric_Square_0.png");
            this.imgLiHead.Images.SetKeyName(84, "Teemo_Square_0.png");
            this.imgLiHead.Images.SetKeyName(85, "Tristana_Square_0.png");
            this.imgLiHead.Images.SetKeyName(86, "Trundle_Square_0.png");
            this.imgLiHead.Images.SetKeyName(87, "Tryndamere_Square_0.png");
            this.imgLiHead.Images.SetKeyName(88, "TwistedFate_Square_0.png");
            this.imgLiHead.Images.SetKeyName(89, "Twitch_Square_0.png");
            this.imgLiHead.Images.SetKeyName(90, "Udyr_Square_0.png");
            this.imgLiHead.Images.SetKeyName(91, "Urgot_Square_0.png");
            this.imgLiHead.Images.SetKeyName(92, "Varus_Square_0.png");
            this.imgLiHead.Images.SetKeyName(93, "Vayne_Square_0.png");
            this.imgLiHead.Images.SetKeyName(94, "Veigar_Square_0.png");
            this.imgLiHead.Images.SetKeyName(95, "Viktor_Square_0.png");
            this.imgLiHead.Images.SetKeyName(96, "Vladimir_Square_0.png");
            this.imgLiHead.Images.SetKeyName(97, "Volibear_Square_0.png");
            this.imgLiHead.Images.SetKeyName(98, "Warwick_Square_0.png");
            this.imgLiHead.Images.SetKeyName(99, "Xerath_Square_0.png");
            this.imgLiHead.Images.SetKeyName(100, "XinZhao_Square_0.png");
            this.imgLiHead.Images.SetKeyName(101, "Yorick_Square_0.png");
            this.imgLiHead.Images.SetKeyName(102, "Ziggs_Square_0.png");
            this.imgLiHead.Images.SetKeyName(103, "Zilean_Square_0.png");
            this.imgLiHead.Images.SetKeyName(104, "Zyra_Square_0.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 562);
            this.Controls.Add(this.pnFrdList);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labShuoShuo);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.picHeadImage);
            this.Name = "frmMain";
            this.Text = "飞鱼聊天";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeadImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picHeadImage;
        public System.Windows.Forms.TextBox txtNick;
        public System.Windows.Forms.Label labShuoShuo;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Panel pnFrdList;
        public System.Windows.Forms.ImageList imgLiHead;
    }
}

