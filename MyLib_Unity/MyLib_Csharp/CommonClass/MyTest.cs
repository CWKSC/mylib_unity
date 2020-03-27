using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MyLib_Csharp.CommonClass
{
    public static class MyTest
    {


        public static void SetTestSetting()
        {
            MyTest.SetProcessPriority();
            MyTest.Warmup(() => { });
        }

        public static void SetProcessPriority()
        {
            // Reference : https://www.codeproject.com/Articles/61964/Performance-Tests-Precise-Run-Time-Measurements-wi
            Process.GetCurrentProcess().ProcessorAffinity = new IntPtr(2); // Uses the second Core or Processor for the Test
            Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;      // Prevents "Normal" processes 
                                                                                        // from interrupting Threads
            Thread.CurrentThread.Priority = ThreadPriority.Highest;     // Prevents "Normal" Threads 
                                                                        // from interrupting this thread
        }

        public static void Warmup(this Action action)
        {
            Console.WriteLine("Warmup");
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200)
            {
                action();
            }
            stopwatch.Stop();
            Console.WriteLine("Warmup finish");
        }
        public static void Warmup<T>(this Func<T> func)
        {
            Console.WriteLine("Warmup");
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            while (stopwatch.ElapsedMilliseconds < 1200)
            {
                func();
            }
            stopwatch.Stop();
        }


        public static string MyToString(this Stopwatch stopwatch)
        {
            return stopwatch.Elapsed.TotalMilliseconds + " ms, " + stopwatch.ElapsedTicks + " ticks";
        }


        public static void TestExecutionTime(this Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }

        public static void TestExecutionTime(this Action action, int times)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for(int i = 0; i < times; i++){ action(); }
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " " + times + " times run " + stopwatch.MyToString() + ", average : " + stopwatch.Elapsed.TotalMilliseconds / times + " ms");
        }

        public static void TestExecutionTime<P1>(this Action<P1> action, P1 p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1>(this Action<P1[]> action, params P1[] p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }


        public static void TestExecutionTime<P1, P2>(this Action<P1, P2> action, P1 p1, P2 p2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3>(this Action<P1, P2, P3> action, P1 p1, P2 p2, P3 p3)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4>(this Action<P1, P2, P3, P4> action, P1 p1, P2 p2, P3 p3, P4 p4)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5>(this Action<P1, P2, P3, P4, P5> action, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4, p5);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5, P6>(this Action<P1, P2, P3, P4, P5, P6> action, P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6) 
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(p1, p2, p3, p4, p5, p6);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1>(this Action<Parameter<P1>> action, Parameter<P1> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2>(this Action<Parameter<P1, P2>> action, Parameter<P1, P2> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3>(this Action<Parameter<P1, P2, P3>> action, Parameter<P1, P2, P3> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4>(this Action<Parameter<P1, P2, P3, P4>> action, Parameter<P1, P2, P3, P4> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5>(this Action<Parameter<P1, P2, P3, P4, P5>> action, Parameter<P1, P2, P3, P4, P5> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }
        public static void TestExecutionTime<P1, P2, P3, P4, P5, P6>(this Action<Parameter<P1, P2, P3, P4, P5, P6>> action, Parameter<P1, P2, P3, P4, P5, P6> parameter)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action(parameter);
            stopwatch.Stop();
            Console.WriteLine(action.Method.Name + " run " + stopwatch.MyToString());
        }




        public static Output TestExecutionTime<Output>(this Func<Output> func)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func();
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.MyToString());
            return output;
        }
        public static void TestExecutionTime<Output>(this Func<Output> func, int times)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for(int i = 0; i < times; i++) { func(); }
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " " + times + " times run " + stopwatch.MyToString() + ", average : " + stopwatch.Elapsed.TotalMilliseconds / times);
        }
        public static Output TestExecutionTime<P1, Output>(this Func<P1, Output> func, P1 p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.MyToString());
            return output;
        }
        public static Output TestExecutionTime<P1, Output>(this Func<P1[], Output> func, params P1[] p1)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.MyToString());
            return output;
        }
        public static void TestExecutionTime<P1, Output>(this Func<P1, Output> func, P1 p1, int times)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < times; i++) { func(p1); }
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " " + times + " times run " + stopwatch.MyToString() + ", average : " + stopwatch.Elapsed.TotalMilliseconds / times);
        }


        public static Output TestExecutionTime<P1, P2, Output>(this Func<P1, P2, Output> func, P1 p1, P2 p2)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1, p2);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.MyToString());
            return output;
        }
        public static Output TestExecutionTime<P1, P2, P3, Output>(this Func<P1, P2, P3, Output> func, P1 p1, P2 p2, P3 p3)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Output output = func(p1, p2, p3);
            stopwatch.Stop();
            Console.WriteLine(func.Method.Name + " run " + stopwatch.MyToString());
            return output;
        }


    }
}
