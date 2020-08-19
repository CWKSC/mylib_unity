using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public class MySecurity
    {

        /// <summary>
        /// 取得MD5加密字串
        /// </summary>
        /// <param name="ConvertString">要加密字串</param>
        /// <param name="isShort">位數  True:16位  False:32位</param>
        /// <param name="isToUpper">大小寫 True:大寫  False:小寫</param>
        public static string MD5Type(string ConvertString, bool isShort = false, bool isToUpper = false)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            string md5Str;
            if (isShort)
                md5Str = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)), 4, 8);
            else
                md5Str = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(ConvertString)));

            md5Str = md5Str.Replace("-", "");

            if (isToUpper)
                return md5Str.ToUpper();
            else
                return md5Str.ToLower();
        }
    }
}
