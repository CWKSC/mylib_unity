using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyDebug
    {
        /// Why don't use msg.Print() to implemenet ?
        /// Conditional must be use void return 
        /// So I can't use MyVoid or string or msg.Print() to be return value

        [Conditional("MyDebug")] public static void Log(string msg) => Console.Write(msg);
        [Conditional("MyDebug")] public static void Logln(string msg) => Console.WriteLine(msg);

        [Conditional("MyDebug")] public static void Call(Action action) => action();
        [Conditional("MyDebug")] public static void Call(Action<object[]> action, params object[] parameters) => action(parameters);
        [Conditional("MyDebug")] public static void Call<T>(Func<T> func) => func();
        [Conditional("MyDebug")] public static void Call<T>(Func<object[], T> func, params object[] parameters) => func(parameters);


        // https://stackoverflow.com/a/171974/11693034
        /// <summary>
        /// Not work int StartCoroutine, IEnumerator method<br/>
        /// Use LogCaller() is better and faster.
        /// </summary>
        [Conditional("MyDebug")]
        public static void LogMethod() => Console.WriteLine(new StackFrame(1).GetMethod().Name);

        // https://stackoverflow.com/a/9621581/11693034
        [Conditional("MyDebug")]
        public static void LogCaller([CallerMemberName] string callerName = "") => Console.WriteLine(callerName);

    }
}
