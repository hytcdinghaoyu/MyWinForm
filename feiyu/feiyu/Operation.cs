using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace feiyu
{
    public class  Operation
    {
        public static List<friend> friendList = new List<friend>();
        public Operation(frmMain frm) 
        {
            _frm = frm;
        }
        private static frmMain _frm;
        public frmMain Frm 
        {
            get 
            {
                return _frm;
            }
            set 
            {
                _frm = value;
            }
            
        }
        public delegate void deleAddFriend(friend frd);
        public void AddFriend(friend frd)
        {
            UCFrdList ucf = new UCFrdList();
            ucf.Frm = _frm;
            ucf.CurFriend = frd;
            ucf.Top=_frm.pnFrdList.Controls.Count * ucf.Height;
            _frm.pnFrdList.Controls.Add(ucf);
        }
        //public static IPAddress GetLocalIP()
        //{
        //    IPAddress[] ipa = Dns.GetHostAddresses(Dn);
        //}
        public void receiveMsg()
        {
            
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipe = new IPEndPoint(IPAddress.Any, 0);
                byte[] btMsg = uc.Receive(ref ipe);
                string receiveMsg = Encoding.Default.GetString(btMsg);
                string[] datas = receiveMsg.Split('|');
                
                if (datas[0] == "LOGIN")
                {   
                    if (datas.Length != 4)
                    {
                        continue;
                    }
                    friend frd = new friend();
                    frd.NickName = datas[1];
                    frd.HeadImage = Convert.ToInt32(datas[2]);
                    frd.ShuoShuo = datas[3];
                    frd.FriendIP = ipe.Address;
                    frd.IsOpen = false;
                    deleAddFriend deleadd = new deleAddFriend(AddFriend);
                    _frm.Invoke(deleadd, frd);
                }
                if (datas[0] == "MSG")
                { 
                    foreach (friend frd in friendList)
                    {
                        if (frd.FriendIP.ToString()==ipe.Address.ToString())
                        {
                            
                            frd.Fc.txtTalkMain.AppendText(datas[2]+":"+datas[1]+"\r\n");
                        }
                    }
                }

            }
        }
        public static void sendMsgToAll(string msg)
        {
            string sendMsg = "";
            switch (msg)
            {
                case "LOGIN": sendMsg = "LOGIN|" + _frm.txtNick.Text + "|11|" + _frm.labShuoShuo.Text;
                    break;
                case "LOGOUT": sendMsg = "LOGOUT|" + _frm.txtNick.Text + "|11|轻轻的我走了！";
                    break;
                default:
                    break;
            }
            UdpClient uc = new UdpClient();
            byte[] btMsg = Encoding.Default.GetBytes(sendMsg);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 9527);
            uc.Send(btMsg, btMsg.Length, ipe);
        }
    }
}
