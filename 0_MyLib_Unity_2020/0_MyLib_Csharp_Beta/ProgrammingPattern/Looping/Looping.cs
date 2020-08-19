using MyLib_Csharp_Beta.CommonType;
using System;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Looping
    {


        /// <summary>
        /// (start, end, step).Loop without condition version, <br />
        /// during effective consideration <br /><br />
        /// <code> (50, 100, 7).Loop(i => (i + " ").Print()).ln(); </code>
        /// Output:
        /// <code> 50 57 64 71 78 85 92 99 </code>
        /// </summary>
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, MyAction<int> action) =>
            args.For(action);
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, Action<int> action) =>
            args.Loop((MyAction<int>)action);



        /// <summary>
        /// (start, end, step).Loop with condition version
        /// <code> (30, 50, 1).Loop(i => (i + " ").Print(), i => i % 2 == 0).lnln(); </code>
        /// Output:
        /// <code> 30 32 34 36 38 40 42 44 46 48 50 </code>
        /// </summary>
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, MyAction<int> action, MyFunc<int, bool> condition = null) => 
            args.Loop(i => { 
                if (condition == null || condition.Invoke(i))
                    action.Invoke(i);
            });
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, Action<int> action, MyFunc<int, bool> condition = null) =>
            args.Loop((MyAction<int>)action, condition);
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, MyAction<int> action, Func<int, bool> condition) =>
            args.Loop(action, (MyFunc<int, bool>)condition);
        public static (int start, int end, int step) Loop(this (int start, int end, int step) args, Action<int> action, Func<int, bool> condition) =>
            args.Loop((MyAction<int>)action, (MyFunc<int, bool>)condition);



        /// <summary>
        /// [start, end] 
        /// <code>
        /// (4, 9).Loop(i => (i + " ").Print()).ln(); <br />
        /// (10, 30).Loop(i => (i + " ").Print(), i => i % 5 == 0).lnln();
        /// </code>
        /// Output:
        /// <code>
        /// 4 5 6 7 8 9 <br />
        /// 10 15 20 25 30
        /// </code>
        /// </summary>
        public static (int start, int end) Loop(this (int start, int end) args, MyAction<int> action, MyFunc<int, bool> condition = null)
        {
            (args.start, args.end, 1).Loop(action, condition);
            return args;
        }
        public static (int start, int end) Loop(this (int start, int end) args, Action<int> action, MyFunc<int, bool> condition = null) =>
            args.Loop((MyAction<int>)action, condition);
        public static (int start, int end) Loop(this (int start, int end) args, MyAction<int> action, Func<int, bool> condition) =>
            args.Loop(action, (MyFunc<int, bool>)condition);
        public static (int start, int end) Loop(this (int start, int end) args, Action<int> action, Func<int, bool> condition) =>
            args.Loop((MyAction<int>)action, (MyFunc<int, bool>)condition);




        /// <summary>
        /// Loop n times
        /// <code>
        /// 5.Loop(i => (i + " ").Print()).ln(); <br />
        /// 14.Loop(i => (i + " ").Print(), i => i % 4 == 0).lnln(); </code>
        /// Output:
        /// <code>
        /// 0 4 8 12 <br />
        /// 0 1 2 3 4
        /// </code>
        /// </summary>
        public static int Loop(this int times, MyAction<int> action, MyFunc<int, bool> condition = null)
        {
            (0, times - 1).Loop(action, condition);
            return times;
        }
        public static int Loop(this int times, Action<int> action, MyFunc<int, bool> condition = null) =>
            times.Loop((MyAction<int>)action, condition);
        public static int Loop(this int times, MyAction<int> action, Func<int, bool> condition) =>
            times.Loop(action, (MyFunc<int, bool>)condition);
        public static int Loop(this int times, Action<int> action, Func<int, bool> condition) =>
            times.Loop((MyAction<int>)action, (MyFunc<int, bool>)condition);



        /// <summary>
        /// Looping for T[] with lambda (ele) => {}
        /// <code>
        /// int[] array = { 3, 6, 2, 1, 8 }; <br />
        /// array.Loop(ele => (ele + " ").Print()).ln();
        /// </code>
        /// Output:
        /// <code> 3 6 2 1 8 </code>
        /// [Another Example]
        /// <code>
        /// (int x, int y)[] points = { (1, 2), (4, 5), (7, 8), (10, 11) }; <br />
        /// points.Loop(ele => $"({ele.x}, {ele.y}) ".Print());
        /// </code>
        /// Output:
        /// <code> (1, 2) (4, 5) (7, 8) (10, 11) </code>
        /// </summary>
        public static T[] Loop<T>(this T[] array, MyAction<T> action)
        {
            Array.ForEach(array, action.action);
            return array;
        }
        public static T[] Loop<T>(this T[] array, Action<T> action) =>
            array.Loop((MyAction<T>)action);




        /// <summary>
        /// Looping for T[] with lambda (ele, i) => {}
        /// <code>
        /// int[] array = { 3, 6, 2, 1, 8 }; <br />
        /// array.Loop((ele, i) => (ele, i).Print()).ln();
        /// </code>
        /// Output:
        /// <code>
        /// (3, 0)(6, 1)(2, 2)(1, 3)(8, 4)
        /// </code>
        /// </summary>
        public static T[] Loop<T>(this T[] array, MyAction<T, int> action)
        {
            array.Length.Loop(i => action.Invoke(array[i], i));
            return array;
        }
        public static T[] Loop<T>(this T[] array, Action<T, int> action) =>
            array.Loop((MyAction<T, int>)action);


        /// <summary>
        /// Looping for T[] with lambda (ele, i) => {} and condition (ele, i) => bool
        /// <code>
        /// int[] array = { 3, 6, 2, 1, 8 }; <br />
        /// array.Loop((ele, i) => (ele, i).Print(), (ele, _) => ele % 2 == 0).lnln();
        /// </code>
        /// Output:
        /// <code>
        /// (6, 1)(2, 2)(8, 4)
        /// </code>
        /// </summary>
        public static T[] Loop<T>(this T[] array, MyAction<T, int> action, MyFunc<T, int, bool> condition = null)
        {
            array.Length.Loop(i => {
                T ele = array[i];
                if (condition == null || condition.Invoke(ele, i))
                    action.Invoke(ele, i);
            });
            return array;
        }
        public static T[] Loop<T>(this T[] array, Action<T, int> action, MyFunc<T, int, bool> condition = null) =>
            array.Loop((MyAction<T, int>)action, condition);

        public static T[] Loop<T>(this T[] array, MyAction<T, int> action, Func<T, int, bool> condition) =>
            array.Loop(action, (MyFunc<T, int, bool>)condition);
        public static T[] Loop<T>(this T[] array, Action<T, int> action, Func<T, int, bool> condition) =>
            array.Loop((MyAction<T, int>)action, (MyFunc<T, int, bool>)condition);

    }
}
