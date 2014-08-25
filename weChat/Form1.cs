using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace weChat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string ip = this.txtIp.Text;
            string sendMsg = "PUBLIC|"+this.txtSendMsg.Text+"|"+this.txtNick.Text;
            byte[] bt=Encoding.Default.GetBytes(sendMsg);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip) ,9527);
            UdpClient uc = new UdpClient();      
            uc.Send(bt,bt.Length,ipe);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain.CheckForIllegalCrossThreadCalls = false;
            Thread th = new Thread(new ThreadStart(revMsg));
            th.IsBackground = true;
            th.Start();
            btnSend.Enabled = false;
        }
        public void revMsg()
        { 
           UdpClient uc = new UdpClient(9527);
           while (true)
           {
               IPEndPoint ipe = new IPEndPoint(IPAddress.Any,0);          
               byte[] bt = uc.Receive(ref ipe);
               string receiveMsg = Encoding.Default.GetString(bt);
               string[] str = receiveMsg.Split('|');
               if (str[0] == "PUBLIC"&&str.Length==3) 
               {
                   this.txtRevMsg.AppendText(str[2]+":"+"\r\n"+"\t"+str[1]+"\r\n");                 
               }
               else if (str[0] == "INROOM" && str.Length == 2)
               {
                   this.txtOnline.AppendText(str[1] + "上线了！" + "\r\n");
               }
               else
               {
                   this.txtRevMsg.AppendText("错误消息无法识别！"+"\r\n");
               }
               
           }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UdpClient uc = new UdpClient();
            string loginTxt = "INROOM|" + this.txtNick.Text;
            byte[] bt = Encoding.Default.GetBytes(loginTxt);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            uc.Send(bt, bt.Length, ipe);
            this.btnLogin.Enabled = false;
            btnSend.Enabled = true;
            txtNick.Enabled = false;
        }
        
    }
}
