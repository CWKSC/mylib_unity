using System;


namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyAlgorithm
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static bool IsSorted<T>(this T[] array, Func<T, T, bool> compare) where T : IComparable
        {
            for (int i = 0; i != array.Length - 1; ++i) 
                if (compare(array[i], array[i + 1])) 
                    return false;
            return true;
        }

        public static bool IsSorted_ascending<T>(this T[] array) where T : IComparable =>
            array.IsSorted((pre, next) => pre.CompareTo(next) > 0);

        public static bool IsSorted_descending<T>(this T[] array) where T : IComparable =>
            array.IsSorted((pre, next) => pre.CompareTo(next) < 0);

        public static void PrintIsSorted_ascending<T>(this T[] array) where T : IComparable =>
            (IsSorted_ascending(array) ? "Sorted (ascending)" : "Unsorted (ascending)").Println();

        public static void PrintIsSorted_descending<T>(this T[] array) where T : IComparable =>
            (IsSorted_descending(array) ? "Sorted (descending)" : "Unsorted (descending)").Println();


        public static T[] SortTwoSortedArray<T>(T[] A, T[] B) where T : IComparable
        {
            int aLength = A.Length;
            int bLength = B.Length;
            T[] result = new T[aLength + bLength];
            int i = 0, j = 0, resultIndex = 0;
            while (true)
            {
                result[resultIndex++] = A[i].CompareTo(B[j]) < 0 ? A[i++] : B[j++];
                if (i == aLength)
                {
                    Array.Copy(B, j, result, resultIndex, bLength - j);
                    break;
                }
                else if(j == bLength)
                {
                    Array.Copy(A, i, result, resultIndex, aLength - i);
                    break;
                }
            }
            return result;
        }


        public static void CreateRandomSortedArray()
        {

        }


    }

}
