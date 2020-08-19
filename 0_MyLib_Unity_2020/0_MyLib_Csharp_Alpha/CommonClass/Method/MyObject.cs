using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyObject
    {

        public static T To<T>(this object value) => (T)Convert.ChangeType(value, typeof(T));


    }
}
