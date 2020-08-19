using System;

using static MyLib_Csharp_Alpha.CommonClass.MyPrint;

namespace MyLib_Csharp_Alpha.Tool
{
    public partial class LagrangeInterpolationPolynomial
    {

        public static void Test()
        {
            LagrangeInterpolationPolynomial lagrangeInterpolationPolynomial
                = new LagrangeInterpolationPolynomial((2, 7), (0, -9), (3, -3), (4, 6), (-5, 3), (1, 5), (-6, 2));
            lagrangeInterpolationPolynomial.Generate(); lnln();
            lagrangeInterpolationPolynomial.Invoke(5).Println();

            //LagrangeInterpolationPolynomial f1
            //    = new LagrangeInterpolationPolynomial((1.5, 2.85), (2.5, 2.4), (3.5, 2.03), (4.5, 1.73), (5.5, 1.5));
            //f1.Generate(); lnln();

            //LagrangeInterpolationPolynomial f2
            //    = new LagrangeInterpolationPolynomial((1.5, 2.81), (2.5, 2.35), (3.5, 1.96), (4.5, 1.65), (5.5, 1.51));
            //f2.Generate(); lnln();

            //LagrangeInterpolationPolynomial f3
            //    = new LagrangeInterpolationPolynomial((1.5, 2.94), (2.5, 2.48), (3.5, 2.08), (4.5, 1.76), (5.5, 1.51));
            //f3.Generate(); lnln();
        }

    }
}
