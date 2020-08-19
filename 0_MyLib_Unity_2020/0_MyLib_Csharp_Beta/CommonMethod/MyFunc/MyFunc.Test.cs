using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyFunc
    {

#pragma warning disable IDE0060 // 移除未使用的參數
        private static void ParamsFunc_Method<R>(ParamsFunc<R> paramsFunc) { }
        private static void ParamsFunc_Method<T, R>(ParamsFunc<T, R> paramsFunc) { }
        private static void RefFunc_Method<T, R>(RefFunc<T, R> refFunc) { }
        private static void OutFunc_Method<T, R>(OutFunc<T, R> outFunc) { }
        private static void InFunc_Method<T, R>(InFunc<T, R> inFunc) { }

#pragma warning restore IDE0060 // 移除未使用的參數


        public static void Test()
        {
            ParamsFunc_Method( args            => 42     ); // get params object[]
            ParamsFunc_Method( (double[] args) => 42     ); // get params T[]
            RefFunc_Method(    (ref double x)  => 42     );
            OutFunc_Method(    (out double x)  => x = 42 );
            InFunc_Method(     (in double x)   => 42     );


        }


    }
}
