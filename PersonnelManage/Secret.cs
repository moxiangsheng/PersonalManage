using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonnelManage
{
    class Secret
    {
        #region 方法：加密
        public string Fun_Secret(string Send_String)
        {
            byte[] Secret_Byte = UTF8Encoding.UTF8.GetBytes(Send_String);
            string Secret_String = Convert.ToBase64String(Secret_Byte);
            return Secret_String;
        }
        #endregion

        #region 方法：解密
        public string Fun_UnSecret(string Get_String)
        {
            byte[] UnSecret_Byte = Convert.FromBase64String(Get_String);
            string UnSecret_String = UTF8Encoding.UTF8.GetString(UnSecret_Byte);
            return UnSecret_String;
        }
        #endregion
    }
}
