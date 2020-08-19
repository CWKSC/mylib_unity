using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyValueTuple
    {


        public static object[] ToObjectArray<T>(this ValueTuple<T> tuple) => new object[] { tuple.Item1 };
        public static object[] ToObjectArray<T1, T2>(this (T1, T2) tuple) => new object[] { tuple.Item1, tuple.Item2 };
        public static object[] ToObjectArray<T1, T2, T3>(this (T1, T2, T3) tuple) => new object[] { tuple.Item1, tuple.Item2, tuple.Item3 };
        public static object[] ToObjectArray<T1, T2, T3, T4>(this (T1, T2, T3, T4) tuple) => new object[] { tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4 };
        public static object[] ToObjectArray<T1, T2, T3, T4, T5>(this (T1, T2, T3, T4, T5) tuple) => new object[] { tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5};



        public static object[] ToObjectArray(this ITuple tuple)
        {
            object[] result = new object[tuple.Length];
            tuple.Length.Loop(i => result[i] = tuple[i]);
            return result;
        }

        public static T[] ToArray<T>(this ITuple tuple)
        {
            T[] result = new T[tuple.Length];
            tuple.Length.Loop(i => result[i] = tuple[i].To<T>());
            return result;
        }


    }
}
