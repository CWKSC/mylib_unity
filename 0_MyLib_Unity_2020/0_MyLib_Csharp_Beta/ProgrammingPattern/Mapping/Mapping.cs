using System;
using System.Collections.Generic;
using System.Text;
using static MyLib_Csharp_Beta.CommonMethod.MyFunc;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Mapping
    {



        public static T[] Map<T>(this T[] dataSet, Func<T, int, T> operation, int[] mapIndex) =>
            dataSet.Loop((ele, i) => dataSet[mapIndex[i]] = operation(ele, i));
        public static T[] Map<T>(this T[] dataSet, Func<T, int, T> operation) =>
            dataSet.Loop((ele, i) => dataSet[i] = operation(ele, i));


        public static T[] Map_new<T>(this T[] dataSet, Func<T, int, T> operation, int[] mapIndex)
        {
            T[] result = new T[dataSet.Length];
            dataSet.Loop((ele, i) => result[mapIndex[i]] = operation(ele, i));
            return result;
        }
        public static T[] Map_new<T>(this T[] dataSet, Func<T, int, T> operation)
        {
            T[] result = new T[dataSet.Length];
            dataSet.Loop((ele, i) => result[i] = operation(ele, i));
            return result;
        }







    }
}
