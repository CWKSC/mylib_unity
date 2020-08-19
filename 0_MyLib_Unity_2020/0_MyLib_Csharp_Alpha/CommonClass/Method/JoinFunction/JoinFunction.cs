using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static partial class JoinFunction
    {


        public static string JoinString<T>(this T[] array, Func<string> work, string joinString) =>
            JoinString(array, (__, ___) => work(), joinString);

        public static string JoinString<T>(this T[] array, Func<T, string> work, string joinString) =>
            JoinString(array, (ele, __) => work(ele), joinString);

        public static string JoinString<T>(this T[] array, Func<T, int, string> work, string joinString)
        {
            if (array.Length == 0) return "";
            StringBuilder result = new StringBuilder();
            result.Append(work(array[0], 0));
            (1, array.Length).Loop((i) =>
            {
                result.Append(joinString);
                result.Append(work(array[i], i));
            });
            return result.ToString();
        }


        public static void JoinPrint(this (int start, int end) args, Func<int, string> work, string joinString) =>
            JoinPrint(args, work, (_) => joinString);

        public static void JoinPrint(this (int start, int end) args, Func<int, string> work, Func<int, string> joinAction)
        {
            Console.Write(work(args.start));
            (args.start + 1, args.end).Loop((i) =>
            {
                Console.Write(joinAction(i));
                Console.Write(work(i));
            });
        }


        public static void JoinPrint<T>(this List<T> list, Action<T> work, string joinString) =>
            JoinPrint(list, (ele, __) => work(ele), () => joinString);

        public static void JoinPrint<T>(this List<T> list, Action<T, int> work, string joinString) =>
            JoinPrint(list, (ele, i) => work(ele, i), () => joinString);

        public static void JoinPrint<T>(this List<T> list, Action<T, int> work, Func<string> joinAction) =>
            JoinPrint(list, (ele, i) => { work(ele, i); return ""; }, (__, ___) => joinAction());


        public static void JoinPrint<T>(this List<T> list, Func<T, int, string> work, string joinString) =>
                JoinPrint(list, work, (__, ___) => joinString);

        public static void JoinPrint<T>(this List<T> list, Func<T, int, string> work, Func<string> joinAction) =>
            JoinPrint(list, work, (__, ___) => joinAction());

        public static void JoinPrint<T>(this List<T> list, Func<T, int, string> work, Func<T, int, string> joinAction) =>
            JoinPrint(list.ToArray(), work, joinAction);


        public static void JoinPrint<T>(this T[] array, string joinString) => 
            array.JoinFunc(
                ele => ele.Print(), 
                () => joinString.Print());


        public static void JoinPrint<T>(this T[] array, Action<T, int> work, string joinString) =>
            JoinPrint(array, (ele, i) => work(ele, i), () => joinString);

        public static void JoinPrint<T>(this T[] array, Action<T, int> work, Func<string> joinAction) =>
            JoinPrint(array, (ele, i) => { work(ele, i); return ""; }, (__, ___) => joinAction());


        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, string joinString) =>
                JoinPrint(array, work, (__, ___) => joinString);

        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, Func<string> joinAction) =>
            JoinPrint(array, work, (__, ___) => joinAction());

        public static void JoinPrint<T>(this T[] array, Func<T, int, string> work, Func<T, int, string> joinAction)
        {
            if (array.Length == 0) return;
            JoinFunc(array, 
                (ele, i) => Console.Write(work(ele, i)), 
                (ele, i) => Console.Write(joinAction(ele, i)));
            //Console.Write(work(array[0], 0));
            //(1, array.Length - 1).Loop((i) =>
            //{
            //    Console.Write(joinAction(array[i], i));
            //    Console.Write(work(array[i], i));
            //});
        }


        public static void JoinPrintSumOf<T>(this T[] array, Action<T, int> work) =>
            JoinPrint(array, work, "+");
        public static void JoinPrintSumOf<T>(this T[] array, Func<T, int, string> work) =>
            JoinPrint(array, work, "+");

        public static void JoinPrintProductOf<T>(this T[] array, Action<T, int> work) =>
            JoinPrint(array, work, "*");
        public static void JoinPrintProductOf<T>(this T[] array, Func<T, int, string> work) =>
            JoinPrint(array, work, "*");


        public static string JoinStringSumOf<T>(this T[] array, Func<T, int, string> work) =>
            JoinString(array, work, "+");
        public static string JoinStringProductOf<T>(this T[] array, Func<T, int, string> work) =>
            JoinString(array, work, "*");



        public static void JoinFunc(this int times, Action<int> work, Action<int> joinAction) =>
            (0, times - 1).JoinFunc(work, joinAction);

        /// <summary> [start, end] </summary>
        public static void JoinFunc(this (int start, int end) args, Action<int> work, Action<int> joinAction)
        {
            work(args.start);
            (args.start + 1, args.end).Loop(i =>
            {
                joinAction(i);
                work(i);
            });
        }


        public static void JoinFunc<T>(this T[] array, Action<T> work, Action joinAction) =>
            JoinFunc(array, (ele, _) => work(ele), (_, __) => joinAction());

        public static void JoinFunc<T>(this T[] array, Action<T> work, Action<T> joinAction) =>
            JoinFunc(array, (ele, _) => work(ele), (ele, _) => joinAction(ele));


        public static void JoinFunc<T>(this T[] array, Action<T, int> work, Action joinAction) =>
            JoinFunc(array, work, (_, __) => joinAction());
        public static void JoinFunc<T>(this T[] array, Action<T, int> work, Action<T> joinAction) =>
            JoinFunc(array, work, (ele, _) => joinAction(ele));

        public static void JoinFunc<T>(this T[] array, Action<T, int> work, Action<T, int> joinAction)
        {
            work(array[0], 0);
            (1, array.Length - 1).Loop(i =>
            {
                joinAction(array[i], i);
                work(array[i], i);
            });
        }


    }
}
