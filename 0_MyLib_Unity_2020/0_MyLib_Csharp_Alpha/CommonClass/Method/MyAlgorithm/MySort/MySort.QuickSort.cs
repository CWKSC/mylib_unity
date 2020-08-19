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

        // It one is wrong //
        // don't use //

        public static T[] QuickSort<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            QuickSort(result, 0, result.Length - 1);
            return result;
        }
        public static void QuickSort<T>(this T[] array, int left, int right) where T : IComparable
        {
            if (left >= right) return;
            T pivot = array[left];
            int i = left + 1;
            int j = right;
            while (true)
            {
                while (i != j && array[j].CompareTo(pivot) > 0) j--;
                while (i != j && array[i].CompareTo(pivot) < 0) i++;
                if (i == j) break;
                Swap(ref array[i], ref array[j]);
            }
            if (pivot.CompareTo(array[i]) > 0)
                Swap(ref array[left], ref array[i]);
            QuickSort(array, left, i - 1);
            QuickSort(array, i + 1, right);
        }

        // Not Unity 
#if !UNITY_5_3_OR_NEWER
        public static T[] QuickSort_Debug<T>(this T[] array) where T : IComparable
        {
            T[] result = (T[])array.Clone();
            QuickSort_Debug(result, 0, result.Length - 1);
            return result;
        }
        public static void QuickSort_Debug<T>(this T[] array, int left, int right) where T : IComparable
        {
            if (left >= right) return;
            T pivot = array[left];
            int i = left + 1;
            int j = right;
            while (i != j)
            {
                while (i != j && array[j].CompareTo(pivot) > 0)
                {
                    MyArray.Println(array, Color.LightGreen, j, left);
                    j--;
                }
                MyArray.Println(array, Color.Yellow, j, left);
                while (i != j && array[i].CompareTo(pivot) < 0)
                {
                    MyArray.Println(array, Color.LightGreen, i, left);
                    i++;
                }
                MyArray.Println(array, Color.LightYellow, i, left);
                if (i == j) break;
                Swap(ref array[i], ref array[j]);
                MyArray.Println(array, Color.Red, i, j);
            }
            if (pivot.CompareTo(array[i]) > 0)
                Swap(ref array[left], ref array[i]);
            MyArray.Println(array, Color.Red, left, i);
            QuickSort_Debug(array, left, i - 1);
            QuickSort_Debug(array, i + 1, right);
        }
#endif

    }
}
