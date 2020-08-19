using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyFunc
    {

        public static double Foo(int n, Func<double, double> func) => Foo(n, (MyFunc<double, double>)func);
        public static double Foo(int n, Func<double> func)         => Foo(n, (MyFunc<double, double>)func);

        public static double Foo(int n, MyFunc<double, double> func)
        {
            double sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += func.Invoke(1);
            }
            return sum;
        }

        public static void Test()
        {
            ("0 + 1 + 2 = " + Foo(3, i => i)).Println();
            ("2 + 2 + 2 = " + Foo(3, () => 2)).Println();
            ("7 + 7 + 7 = " + Foo(3, 7)).Println(); 
        }

    }

}
