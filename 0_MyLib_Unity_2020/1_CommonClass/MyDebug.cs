using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MyDebug
{

    [System.Diagnostics.Conditional("MyDebug")] public static void Assert(bool condition) => Debug.Assert(condition);
    [System.Diagnostics.Conditional("MyDebug")] public static void Log(object message) => Debug.Log(message);
    [System.Diagnostics.Conditional("MyDebug")] public static void LogWarning(object message) => Debug.LogWarning(message);
    [System.Diagnostics.Conditional("MyDebug")] public static void LogWarningFormat(string format, params object[] args) => Debug.LogWarningFormat(format, args);
    [System.Diagnostics.Conditional("MyDebug")] public static void LogError(object message) => Debug.LogError(message);
    [System.Diagnostics.Conditional("MyDebug")] public static void LogException(Exception exception) => Debug.LogException(exception);


    // https://stackoverflow.com/a/171974/11693034
    /// <summary>
    /// Not work int StartCoroutine, IEnumerator method<br/>
    /// Use LogCaller() is better and faster.
    /// </summary>
    [System.Diagnostics.Conditional("MyDebug")]
    public static void LogMethod() => Debug.Log(new System.Diagnostics.StackFrame(1).GetMethod().Name);


    // https://stackoverflow.com/a/9621581/11693034
    [System.Diagnostics.Conditional("MyDebug")]
    public static void LogCaller([CallerMemberName] string callerName = "") => Debug.Log(callerName);


}
