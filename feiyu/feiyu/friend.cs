using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace feiyu
{
    public class friend
    {
        public string NickName{get;set;}
        public int HeadImage{get; set;}
        public string ShuoShuo{get; set;}
        public IPAddress FriendIP { get; set; }
        public bool IsOpen { get; set; }
        public frmChat Fc { get; set; }
        public List<string> msgList = new List<string>();
    }
}
