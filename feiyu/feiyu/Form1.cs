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
            //Operation.sendMsgToAll("LOGIN");
        }    
        private void frmMain_Load(object sender, EventArgs e)
        {
            frmMain.CheckForIllegalCrossThreadCalls = false;
            Operation ope = new Operation(this);
            Thread th = new Thread(ope.receiveMsg);
            th.IsBackground = true;     
            th.Start();
            Thread.Sleep(100);
            Operation.sendMsgToAll("LOGIN");
           
        }
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Operation.sendMsgToAll("LOGOUT");
            
        }
        
    }
}
