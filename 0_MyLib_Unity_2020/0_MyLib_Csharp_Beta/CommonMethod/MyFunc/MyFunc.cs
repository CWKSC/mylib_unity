using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyFunc
    {


        public delegate R ParamsFunc<R>(params object[] args);
        public delegate R ParamsFunc<T, R>(params T[] args);
        public delegate R RefFunc<T, R>(ref T arg);
        public delegate R OutFunc<T, R>(out T arg);
        public delegate R InFunc<T, R>(in T arg);


        public delegate RecursionParamsFuncFunc RecursionParamsFuncFunc(params object[] args);
        public delegate RecursionParamsFunc<T> RecursionParamsFunc<T>(params T[] args);
        public delegate RecursionRefFunc<T> RecursionRefFunc<T>(ref T arg);
        public delegate RecursionOutFunc<T> RecursionOutFunc<T>(out T arg);
        public delegate RecursionInFunc<T> RecursionInFunc<T>(in T arg);


    }
}
