using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyMath
    {

        public static void FindRootTest()
        {
            FindRootNum_Linear(XPow2_sub_0_5, -10, 10, 100).Println();
            (double start, double end) = BisectionMethod(XPow2_sub_0_5, -10, 10, 100);
            (start + " < x < " + end).Println();
        }


        public static int FindRootNum_Linear(Func<double, double> f, double start, double end, int piece)
        {
            double totalLength = end - start;
            double step = totalLength / piece;
            int rootNum = 0;
            double current = f(start);
            bool sign = current > 0;
            piece.Loop(() =>
            {
                start += step;
                current = f(start);
                if (sign != current > 0)
                {
                    rootNum++;
                    sign = !sign;
                }
            });
            return rootNum;
        }

        public static (double, double) BisectionMethod(Func<double, double> f, double start, double end, int times)
        { 
            times.Loop(() =>
            {
                double cut = (start + end) / 2;
                if (f(cut) * f(end) < 0)
                {
                    start = cut;
                }
                else
                {
                    end = cut;
                }
            });
            return (start, end);
        }



    }
}
