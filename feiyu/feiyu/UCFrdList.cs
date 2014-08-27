using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace feiyu
{
    
    public partial class UCFrdList : UserControl
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
                this.lblNick.Text = value.NickName;
                this.pictureBox1.Image= this.frm.imgLiHead.Images[value.HeadImage];
                this.lblShuoShuo.Text = value.ShuoShuo;
            }
        }
        public UCFrdList()
        {
            InitializeComponent();           
        }
        private void UCFrdList_Click(object sender, EventArgs e)
        {
            if (this.curFriend.IsOpen == false) 
            {
                frmChat fc = new frmChat();
                fc.Show(); 
                this.curFriend.IsOpen = true;      
                fc.Frm = this.frm;        
                fc.CurFriend = this.curFriend;
                this.curFriend.Fc = fc;                
                Operation.friendList.Add(this.curFriend);
            }
        }

        private void UCFrdList_Load(object sender, EventArgs e)
        {

        }
    }
}
