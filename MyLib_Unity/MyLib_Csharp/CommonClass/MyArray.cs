using System;
using System.Drawing;
using System.Linq;

namespace MyLib_Csharp.CommonClass
{
    public static class MyArray
    {

        public static int[] GenerateRandIntArray(int n)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(int.MinValue, int.MaxValue);
            }
            return result;
        }

        /// <summary>[min, max)</summary>
        public static int[] GenerateRandIntArray(int n, int min, int max)
        {
            int[] result = new int[n];
            Random random = new Random();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = random.Next(min, max);
            }
            return result;
        }

        public static int[,] GenerateRandInt2dArray(int n, int m)
        {
            int[,] result = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    result[i, j] = random.Next(int.MinValue, int.MaxValue);
                }
            }
            return result;
        }


        public static void Print<T>(T[] array)
        {
            foreach(T element in array)
            {
                Console.Write(element + " ");
            }
        }
        public static void Println<T>(this T[] array)
        {
            Print(array);
            Console.Write('\n');
        }


        public static void Print<T>(T[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.Write('\n');
            }
        }



        /// <summary>
        /// 打亂陣列中順序
        /// </summary>
        public static void Shuffle<T>(T[] Source)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            if (Source == null) return;

            int len = Source.Length;

            int r;

            //暫存用
            T tmp;
            Random random = new Random();

            for (int i = 0; i < len - 1; i++)
            {
                //取亂數，範圍包含最小值，不包含最大值
                r = random.Next(i, len);

                //如果一樣則重取            
                if (i == r) continue;

                //取亂數後的索引與原來的交換
                tmp = Source[i];
                Source[i] = Source[r];
                Source[r] = tmp;
            }
        }

    }
}
