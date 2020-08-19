using MyLib_Csharp_Alpha.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static partial class MyAlgorithm
    {

        /// <summary>[min, max]</summary>
        public static int[] CountingSort(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            for (int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] - min];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index - min] != 0)
                {
                    result[j] = index;
                    --countArray[index - min];
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
        public static int[] CountingSort2(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            CountingArray countingArray = new CountingArray(min, max, result);

            int resultIndex = 0;
            MyLoop.LoopIndex(min, index =>
            {
                result[resultIndex++] = index;
                --countingArray[index];
            }, 
            _ => false, 
            index => countingArray[index] == 0, 
            _ => resultIndex == result.Length);
            return result;
        }


        // TODO: try to use hash table in Counting Sort
        // write in 16/6/2020



        /// <summary>[min, max]</summary>
        public static int[] CountingSort_Debug(this int[] array, int min, int max)
        {
            int[] result = (int[])array.Clone();
            int[] countArray = new int[max - min + 1];
            for (int i = 0; i < result.Length; i++)
            {
                ++countArray[result[i] - min];
            }

            int j = 0;
            int index = min;
            while (j < result.Length)
            {
                if (countArray[index - min] != 0)
                {
                    result[j] = index;
                    --countArray[index - min];
                }
                else
                {
                    ++index;
                    continue;
                }
                ++j;
            }
            result.Println();
            return result;
        }

    }
}
