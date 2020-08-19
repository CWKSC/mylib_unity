using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyMap
    {

        public static T[] Map<T>(this T[] dataSet, Func<T, T> operation, int?[] mapIndex = null)
        {
            T[] result = new T[dataSet.Length];
            if (mapIndex == null)
            {
                dataSet.ForEach((ele, i) => 
                    result[i] = operation(ele));
                return result;
            }

            // mapIndex not null here
            dataSet.ForEach((ele, i) =>
            {
                if (mapIndex[i] != null)
                    result[(int)mapIndex[i]] = operation(ele);
            });
            return result;
        }

        public static T[] Map<T>(this T[] dataSet, Func<T, T> operation)
        {
            T[] result = new T[dataSet.Length];
            dataSet.ForEach((ele, i) => result[i] = operation(ele));
            return result;
        }





        public static Func<T, R> Map<T, R>(this Func<T, R> func, Func<R, R> operation) => 
            x => operation(func(x));



        public static void Test()
        {

        }

    }
}
