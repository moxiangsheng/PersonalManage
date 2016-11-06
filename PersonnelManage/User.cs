using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelManage
{
    class User
    {
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string userPwd;

        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
    }
}
