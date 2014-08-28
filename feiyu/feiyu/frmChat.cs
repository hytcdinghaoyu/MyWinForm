using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace feiyu
{
    public partial class frmChat : Form
    {
        private frmMain frm;
        public frmMain Frm
        {
            get
            {
                return frm;
            }
            set
            {
                this.frm = value;

            }
        }
        private friend curFriend;
        public friend CurFriend
        {
            get
            {
                return curFriend;
            }
            set
            {
                this.curFriend = value;
                this.lblFrdNick.Text = value.NickName;
                this.picFrdHead.Image = this.frm.imgLiHead.Images[value.HeadImage];
                this.lblShuoShuo.Text = value.ShuoShuo;
            }
        }
        public frmChat()
        {
            InitializeComponent();
        }
        private void lblFrdNick_Click(object sender, EventArgs e)
        {

        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string sendMsg = "MSG|" + this.txtMsgMain.Text+"|小跳蚤";
            byte[] btMsg = Encoding.Default.GetBytes(sendMsg);
            IPEndPoint ipe = new IPEndPoint(this.curFriend.FriendIP,9527);
            uc.Send(btMsg,btMsg.Length,ipe);
            this.txtTalkMain.AppendText("我:"+this.txtMsgMain.Text+"\r\n");
        }
        private void frmChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.curFriend.IsOpen = false;
            Operation.friendList.Remove(this.curFriend);
        }

        private void frmChat_Load(object sender, EventArgs e)
        {

        }
    }
}
