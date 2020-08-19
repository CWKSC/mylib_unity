using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{

    public static class MyFunction
    {

        public static void Test()
        {
            static RecursionRefFunc<T> TestRecursionRefFunc<T>(ref T input)
            {
                input = default;
                return TestRecursionRefFunc;
            }
            static RecursionOutFunc<int> TestRecursionOutFunc(out int input)
            {
                input = 1;
                return TestRecursionOutFunc;
            }
            static RecursionParamsFunc<int> TestRecursionParamsFunc<T>(params T[] args)
            {
                args.Println();
                return TestRecursionParamsFunc;
            }

            int x1 = 1, x2 = 2, x3 = 3, x4 = 4, x5 = 5;

            (x1, x2, x3, x4, x5).Println();
            TestRecursionRefFunc(ref x1)(ref x2)(ref x3)(ref x4)(ref x5);
            (x1, x2, x3, x4, x5).Println();

            TestRecursionOutFunc(out int x6)(out int x7)(out int x8);
            (x6, x7, x8).Println();

            TestRecursionParamsFunc(1)(2, 3)(4, 5, 6);
        }


        public delegate OUT ParamsFunc<OUT>(params object[] args);
        public delegate OUT ParamsFunc<IN, OUT>(params IN[] args);
        public delegate OUT RefFunc<IN, OUT>(ref IN arg);
        public delegate OUT OutFunc<IN, OUT>(out IN arg);
        public delegate OUT InFunc<IN, OUT>(in IN arg);


        public delegate RecursionParamsFuncFunc RecursionParamsFuncFunc(params object[] args);
        public delegate RecursionParamsFunc<T> RecursionParamsFunc<T>(params T[] args);
        public delegate RecursionRefFunc<T> RecursionRefFunc<T>(ref T arg);
        public delegate RecursionOutFunc<T> RecursionOutFunc<T>(out T arg);
        public delegate RecursionInFunc<T> RecursionInFunc<T>(in T arg);


        public static Func<int, T> ToFunc<T>(this T[] array) => 
            i => array[i];


        public static Func<T> ToFunc<T>(this T value) => () => value;


        public static Func<int, object[], double> ToNoArgsLoopFunc(this Func<int, double> f) => (x, _) => f(x);

        public static Func<int, T> ToIntInputFunc<T>(this Func<double, T> f) => x => f(x);





    }
}
