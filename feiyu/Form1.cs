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
using System.Threading;
namespace feiyu
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string sendMsg = "LOGIN|" + this.txtNick.Text + "|11|" + this.labShuoShuo.Text;
            byte[] btMsg = Encoding.Default.GetBytes(sendMsg);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("255.255.255.255"),9527);
            uc.Send(btMsg,btMsg.Length,ipe);
        }

        public delegate void deleAddFriend(frdList frd);
        public void AddFriend(frdList frd)
        {
            UCFrdList ucf = new UCFrdList();       
            ucf.Frm = this;
            ucf.CurFriend = frd;
            ucf.Top = this.pnFrdList.Controls.Count * ucf.Height;
            this.pnFrdList.Controls.Add(ucf);
        }
        public void receiveMsg()
        { 
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                byte[] btMsg = uc.Receive(ref ipe);
                string receiveMsg = Encoding.Default.GetString(btMsg);
                string[] datas = receiveMsg.Split('|');
                if (datas.Length != 4)
                {
                    continue;
                }
                if (datas[0] == "LOGIN")
                {          
                    
                    frdList frd = new frdList();
                    frd.NickName = datas[1];
                    frd.HeadImage =Convert.ToInt32(datas[2]);
                    frd.ShuoShuo = datas[3];                              
                    deleAddFriend deleadd = new deleAddFriend(AddFriend);
                    this.pnFrdList.Invoke(deleadd,frd);
                    //this.pnFrdList.Controls.Add(ucf);
                    //this.pnFrdList.Invoke();
                }

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(receiveMsg);
            th.IsBackground = true;
            Thread.Sleep(500);
            th.Start();
            //for (int i = 0; i < 10; i++)
            //{
            //    ucfrdlist ucf = new ucfrdlist();
            //    ucf.top = i * ucf.height;
            //    this.pnfrdlist.controls.add(ucf);

            //}
            
        }
    }
}
