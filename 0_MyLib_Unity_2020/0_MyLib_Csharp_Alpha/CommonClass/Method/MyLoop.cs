using MyLib_Csharp_Alpha.CommonClass.MyType;
using System;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyLoop
    {


        public static void ForEach<T>(this T[] array, Action<T> action) => Array.ForEach(array, action);
        public static void ForEach<T>(this T[] array, Action<T, int> action) => array.Length.Loop(i => action(array[i], i));


        public static void Loop(this int times, Action action, Predicate<int> condition = null) =>
            times.Loop(_ => action(), condition);

        /// <summary> [0, times) </summary>
        public static void Loop(this int times, Action<int> action, Predicate<int> condition = null) =>
            (0, times - 1).Loop(action, condition);



        public static void Loop(this (int start, int end) args, Action action) =>
            args.Loop(_ => action());


        public static void Loop(this (int start, int end) args, Action<int> action) =>
            (args.start, args.end, 1).Loop(action);


        public static void Loop(this (int start, int end) args, Action action, Predicate<int> condition) => 
            Loop(args, _ => action(), condition);


        /// <summary> [start, end] </summary>
        public static void Loop(this (int start, int end) args, Action<int> action, Predicate<int> condition = null) =>
            (args.start, args.end, 1).Loop(action, condition);




        public static void Loop(this (int start, int end, int step) args, Action action) =>
            args.Loop((MyAction<int>)action);

        public static void Loop(this (int start, int end, int step) args, Action action, Predicate<int> condition) =>
            args.Loop((MyAction<int>)action, condition);

        public static void Loop(this (int start, int end, int step) args, MyAction<int> action)
        {
            for (int i = args.start; i <= args.end; i += args.step)
                action.Invoke(i);
        }

        public static void Loop(this (int start, int end, int step) args, MyAction<int> action, Predicate<int> condition = null)
        {
            for (int i = args.start; i <= args.end; i += args.step)
                if(condition == null || condition(i))
                    action.Invoke(i);
        }



        public static void LoopIndex(int index, Action<int> action, Func<int, bool> moveLeftCondition, Func<int, bool> moveRightCondition, Func<int, bool> breakCondition)
        {
            while (true)
            {
                if (breakCondition(index)) break;
                if (moveLeftCondition(index)) --index;
                if (moveRightCondition(index)) ++index;
                action(index);
            }
        }



        public static void LoopCombination<T>(this T[] array, Action<T, T> action) => 
            (0, array.Length).Loop(i => 
                (i + 1, array.Length).Loop(j =>
                    action(array[i], array[j]) ) );


    }
}
