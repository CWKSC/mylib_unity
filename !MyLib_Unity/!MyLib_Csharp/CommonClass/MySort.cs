using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading;

namespace MyLib_Csharp.CommonClass
{
    public static class MySort
    {

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

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




        public static T[] SelectionSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            for (int i = 0; i < result.Length; i++)
            {
                int maxIndex = 0;
                for (int j = 0; j < result.Length - i ; j++)
                {
                    if(result[j].CompareTo(result[maxIndex]) > 0)
                    {
                        maxIndex = j;
                    }
                }
                Swap(ref result[maxIndex], ref result[result.Length - 1 - i]);
            }
            return result;
        }




        /// <summary>[min, max]</summary>
        public static int[] CountingSort(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            int absMin = Math.Abs(min);
            for(int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] + absMin];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index + absMin] != 0)
                {
                    result[j] = index;
                    --countArray[index + absMin];
                }
                else
                {
                    ++index;
                    continue;
                }
                ++j;
            }
            return result;
        }
        /// <summary>[min, max]</summary>
        public static int[] CountingSort_Debug(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            int absMin = Math.Abs(min);
            for (int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] + absMin];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index + absMin] != 0)
                {
                    result[j] = index;
                    --countArray[index + absMin];
                }
                else
                {
                    ++index;
                    continue;
                }
                ++j;
            }
            MyArray.Println(result);
            return result;
        }

        public static void PrintIsSorted_ascending<T>(this T[] array) where T : IComparable
        {
            if (IsSorted_ascending(array))
            {
                Console.WriteLine("Sorted (ascending)");
            }
            else
            {
                Console.WriteLine("Unsorted (ascending)");
            }
        }
        public static bool IsSorted_ascending<T>(this T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void PrintIsSorted_descending<T>(this T[] array) where T : IComparable
        {
            if (IsSorted_descending(array))
            {
                Console.WriteLine("Sorted (descending)");
            }
            else
            {
                Console.WriteLine("Unsorted (descending)");
            }
        }
        public static bool IsSorted_descending<T>(this T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1].CompareTo(array[i]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void Test()
        {
            const int dataLength = 10;
            const int dataMin = -500;
            const int dataMax = 500;
            int[] allRangeIntArray = MyArray.GenerateRandIntArray(dataLength);
            int[] inRangeIntArray = MyArray.GenerateRandIntArray(dataLength, dataMin, dataMax);

            MyTest.SetTestSetting();


            /* Uncomment to see sorting flow
             * many Print and so dataLength = 10 is suitable 
             * (add "*" here to uncomment quickly) --> /
            
            Console.WriteLine("Start sorting flow / correctness test");

            // BubbleSort //
            MyTest.TestExecutionTime(BubbleSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
            MyTest.TestExecutionTime(BubbleSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
            Console.WriteLine();

            // SelectionSort //
            MyTest.TestExecutionTime(SelectionSort_Debug, allRangeIntArray).PrintIsSorted_ascending();
            MyTest.TestExecutionTime(SelectionSort_Debug, inRangeIntArray).PrintIsSorted_ascending();
            Console.WriteLine();

            // CountingSort //
            MyTest.TestExecutionTime(CountingSort_Debug, inRangeIntArray, dataMin, dataMax).PrintIsSorted_ascending();
            Console.WriteLine();

            //*/

            // BubbleSort //
            MyTest.TestExecutionTime(BubbleSort, allRangeIntArray);
            MyTest.TestExecutionTime(BubbleSort, inRangeIntArray);
            // SelectionSort //
            MyTest.TestExecutionTime(SelectionSort, allRangeIntArray);
            MyTest.TestExecutionTime(SelectionSort, inRangeIntArray);
            // CountingSort //
            MyTest.TestExecutionTime(CountingSort, inRangeIntArray, dataMin, dataMax);
        }
    }
}
