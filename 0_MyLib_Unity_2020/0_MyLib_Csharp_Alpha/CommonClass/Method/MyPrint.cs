using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyPrint
    {


#pragma warning disable IDE1006 // 命名樣式
        public static void ln() => ln(1);
        public static void lnln() => ln(2);
        public static void lnlnln() => ln(3);
        public static void ln<T>(T _) => ln();
        public static void lnln<T>(T _) => lnln();
        public static void lnlnln<T>(T _) => lnlnln();
        public static void ln(int times) => Console.Write(new string('\n', times));

#pragma warning restore IDE1006 // 命名樣式


        public static T Print<T>(this T value) { Console.Write(value); return value; }
        public static T Println<T>(this T value) { Console.WriteLine(value); return value; }
        public static T Printlnln<T>(this T value) { Console.WriteLine(value + "\n"); return value; }
        public static T Printlnlnln<T>(this T value) { Console.WriteLine(value + "\n\n"); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrint<T>(this T value) { Console.Write("\n" + value); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrintln<T>(this T value) { Console.WriteLine("\n" + value); return value; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名樣式", Justification = "<暫止>")]
        public static T lnPrintlnln<T>(this T value) { Console.WriteLine("\n" + value + "\n"); return value; }


        public static T[] Print<T>(this T[] array)
        {
            array.JoinPrint(" ");
            return array;
        }
        public static T[] Println<T>(this T[] array)
        {
            array.Print(); ln();
            return array;
        }
        public static T[] Printlnln<T>(this T[] array)
        {
            array.Println(); ln();
            return array;
        }


        public static string Print_dontMoveCursor(this string str) {
            str.Print();
            MyConsole.MoveCursorLeft(str.Length);
            return str;
        }


        public static string[] Print(this string[] strArray)
        {
            strArray.ForEach(ele =>
            {
                ele.Print_dontMoveCursor();
                MyConsole.MoveCursorDown();
            });
            return strArray;
        }



    }
}
