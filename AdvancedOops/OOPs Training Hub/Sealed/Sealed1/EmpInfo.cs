using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    sealed class EmpInfo
    {
        private static int s_keyInfo=100;
        public string KeyInfo { get;  }
        public string UserID { get; set; }
        public string Password { get; set; }

        public EmpInfo(string userID,string password)
        {
            s_keyInfo++;
            KeyInfo="SF"+s_keyInfo;
            UserID=userID;
            Password=password;

        }
        public void DisplayKey()
        {
           
        }
    }

}