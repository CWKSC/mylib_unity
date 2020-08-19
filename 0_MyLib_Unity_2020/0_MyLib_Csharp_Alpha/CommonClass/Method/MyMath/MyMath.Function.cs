using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using static System.Math;
using static MyLib_Csharp_Alpha.CommonClass.MyCalculus;
using static MyLib_Csharp_Alpha.CommonClass.MyPrint;

namespace MyLib_Csharp_Alpha.CommonClass
{

    public static partial class MyMath
    {


        public static void FunctionTest()
        {

            "Sum of 1 to 100".Println();
            SumOf(1, 100, (i) => i).Printlnln();

            "Tabling Gamma Function 1 to 10".Println();
            Tabling_Func((x) => Gamma(x), 1, 10); ln(2);

            ITuple initValue = (0, 1);
            static double recurrenceRelationFunc(List<double> T, int n) => T[n - 1] + T[n - 2];
            double Fibonacci(int n) => initValue.RecurrenceRelation(recurrenceRelationFunc, n);
            void PrintFibonacci(int n) => ($"Fibonacci({n}) : " + Fibonacci(n)).Println();
            (0, 7).Loop(n => PrintFibonacci(n));
            PrintFibonacci(100);

            /*
            Sum of 1 to 100
            5050

            Tabling Gamma Function 1 to 10
            1.0005000833332944, 0.9999999166666648, 1.9999999999999267, 5.9999999999994955, 23.999999999996597, 119.99999999998577, 719.9999999999474, 5040.000000000014, 40320.000000003434, 362880.00000005425

            Fibonacci(0) : 0
            Fibonacci(1) : 1
            Fibonacci(2) : 1
            Fibonacci(3) : 2
            Fibonacci(4) : 3
            Fibonacci(5) : 5
            Fibonacci(6) : 8
            Fibonacci(7) : 13
            Fibonacci(100) : 3.54224848179262E+20
            */
        }




        public static double SumOf(int start, int end,
            Func<int, double> f,
            Predicate<int> condition = null) =>  SumOf(start, end, f.ToNoArgsLoopFunc(), null, condition);

        public static double SumOf(int start, int end, 
            Func<int, object[], double> f, object[] args = null,
            Predicate<int> condition = null)
        {
            double sum = 0;
            (start, end).Loop((i) => sum += f(i, args), condition);
            return sum;
        }



        public static double ProductOf(int start, int end,
            Func<int, double> f,
            Predicate<int> condition) => 
                ProductOf(start, end, f.ToNoArgsLoopFunc(), null, condition);

        public static double ProductOf(int start, int end, 
            Func<int, object[], double> f, object[] args = null, 
            Predicate<int> condition = null)
        {
            double productOf = 1;
            (start, end).Loop(i => productOf *= f(i, args), condition);
            return productOf;
        }




        /// <summary>
        /// (t0, t1, ...).RecurrenceRelation((T, n) => /* ... */, n);
        /// </summary>
        public static double RecurrenceRelation(this ITuple initValue, Func<List<double>, int, double> recurrenceRelationFunc, int n)
        {
            if (initValue.Length > n) return initValue[n].To<double>();
            List<double> sequence = new List<double>(initValue.ToArray<double>());
            (initValue.Length, n).Loop(i => sequence.Add(recurrenceRelationFunc(sequence, i)));
            return sequence[n];
        }





        /// <summary>
        /// [start, end]
        /// </summary>
        public static void Tabling_Func<T>(Func<int, T> f, int start, int end) => 
            (start, end).JoinPrint(i => f(i).ToString(), ", ");


        public static double Gamma(double z) => 
            Integral(0, 100,
                t => Pow(t, z - 1) / Exp(t));


        public static double XPow2_sub_0_5(double x) => x * x - 0.5;

        public static double XPow10_sub_1(double x) => Pow(x, 10) - 1;


    }
}
