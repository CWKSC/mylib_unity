using System;
using System.Collections.Generic;
using System.Text;

// Not Unity //
#if !UNITY_5_3_OR_NEWER
using System.Drawing;
#endif


namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyAlgorithm
    {
        public static T[] BubbleSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 1; j < result.Length - i; j++)
                {
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        Swap(ref result[j - 1], ref result[j]);
                    }
                }
            }
            return result;
        }

        // Not Unity //
#if !UNITY_5_3_OR_NEWER
        public static T[] BubbleSort_Debug<T>(this T[] array) where T : IComparable
        {
            int ifCount = 0, matchIfCount = 0, swapCount = 0;
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 1; j < result.Length - i; j++)
                {
                    MyArray.Println(result, Color.LightGreen, j - 1, j);
                    ifCount++;
                    if (result[j - 1].CompareTo(result[j]) > 0)
                    {
                        matchIfCount++;
                        MyArray.Println(result, Color.Yellow, j - 1, j);
                        Swap(ref result[j - 1], ref result[j]);
                        MyArray.Println(result, Color.Red, j - 1, j);
                        swapCount++;
                    }
                }
            }
            Console.WriteLine("Check condition (Green) times: " + ifCount);
            Console.WriteLine("Match condition (Yellow) times: " + matchIfCount);
            Console.WriteLine("Swap (Red) times: " + swapCount);
            return result;
        }
#endif

    }
}
