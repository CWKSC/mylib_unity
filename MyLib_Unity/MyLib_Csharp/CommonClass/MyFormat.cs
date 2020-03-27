using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyFormat
    {

        /// <summary>
        /// 根據數值回傳 B M K 格式字串
        /// EX: 5.23B、18.7M、152K
        /// </summary>
        public static string ValueToString(int value)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            float fValue;
            int iValue;
            if (Math.Abs(value) < 1000)
            {
                return value.ToString();
            }
            else if (Math.Abs(value) < 10000)
            {
                iValue = (value * 100) / 1000;
                fValue = iValue / 100.0f;
                return string.Format("{0:0.00}K", fValue);
            }
            else if (Math.Abs(value) < 100000)
            {
                iValue = (value * 10) / 1000;
                fValue = iValue / 10.0f;
                return string.Format("{0:00.0}K", fValue);
            }
            else if (Math.Abs(value) < 1000000)
            {
                iValue = value / 1000;
                return string.Format("{0}K", iValue);
            }
            else if (Math.Abs(value) < 10000000)
            {
                iValue = (value * 100) / 1000000;
                fValue = iValue / 100.0f;
                return string.Format("{0:0.00}M", fValue);
            }
            else if (Math.Abs(value) < 100000000)
            {
                iValue = (value * 10) / 1000000;
                fValue = iValue / 10.0f;
                return string.Format("{0:00.0}M", fValue);
            }
            else if (Math.Abs(value) < 1000000000)
            {
                iValue = value / 1000000;
                return string.Format("{0}M", iValue);
            }
            else if (Math.Abs((long)value) < 10000000000)
            {
                iValue = (int)((value * 100) / 1000000000);
                fValue = iValue / 100.0f;
                return string.Format("{0:0.00}B", fValue);
            }


            return value.ToString();
        }


        /// <summary>
        /// 將TimeSpan轉為 時、分、秒，未滿單位不顯示
        /// EX： 50:18:29
        /// </summary>
        public static string TimeSpanToString(TimeSpan span)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            if (span.TotalHours > 1)
                return string.Format("{0:00}:{1:00}:{2:00}", span.Hours, span.Minutes, span.Seconds);
            else if (span.TotalMinutes > 1)
                return string.Format("{0:00}:{1:00}", span.Minutes, span.Seconds);
            else
                return string.Format("{0:00}", span.Seconds);
        }
        /// <summary>
        /// 將TimeSpan轉為 天、時、分、秒，未滿單位不顯示
        /// EX： 5d 6h 30m 45s
        /// </summary>
        public static string TimeSpanToStringLetter(TimeSpan span)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            if (span.TotalDays > 1)
                return string.Format("{0}d {1}h {2}m {3}s", span.Days, span.Hours, span.Minutes, span.Seconds);
            else if (span.TotalHours > 1)
                return string.Format("{0}h {1}m {2}s", span.Hours, span.Minutes, span.Seconds);
            else if (span.TotalMinutes > 1)
                return string.Format("{0}m {1}s", span.Minutes, span.Seconds);
            else
                return string.Format("{0}s", span.Seconds);
        }

        /// <summary>
        /// 判斷是否是URL
        /// </summary>
        public static bool IsUrl(string url)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            return System.Text.RegularExpressions.Regex.IsMatch(url, RegularExp.Url);
        }
        public struct RegularExp
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            public const string Url = @"^http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?$";
        }
    }
}
