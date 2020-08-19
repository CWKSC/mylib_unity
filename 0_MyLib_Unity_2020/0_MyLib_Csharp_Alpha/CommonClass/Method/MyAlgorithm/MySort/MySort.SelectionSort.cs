using System;
using System.Collections.Generic;
using System.Text;

// Not Unity 
#if !UNITY_5_3_OR_NEWER
using System.Drawing;
#endif


namespace MyLib_Csharp_Alpha.CommonClass
{
    public static partial class MyAlgorithm
    {

        public static T[] SelectionSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i; j++)
                {
                    if (result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[result.Length - 1 - i]);
            }
            return result;
        }

        // Not Unity //
#if !UNITY_5_3_OR_NEWER
        public static T[] SelectionSort_Debug<T>(this T[] array) where T : IComparable
        {
            int ifCount = 0, matchIfCount = 0, swapCount = 0;
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i; j++)
                {
                    MyArray.Println(result, Color.LightGreen, j, maxIndex);
                    ifCount++;
                    if (result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        matchIfCount++;
                        MyArray.Println(result, Color.Yellow, j, maxIndex);
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[result.Length - 1 - i]);
                MyArray.Println(result, Color.Red, maxIndex, result.Length - 1 - i);
                swapCount++;
            }
            Console.WriteLine("Check condition (Green) times: " + ifCount);
            Console.WriteLine("Match condition (Yellow) times: " + matchIfCount);
            Console.WriteLine("Swap (Red) times: " + swapCount);
            return result;
        }
#endif


    }
}
