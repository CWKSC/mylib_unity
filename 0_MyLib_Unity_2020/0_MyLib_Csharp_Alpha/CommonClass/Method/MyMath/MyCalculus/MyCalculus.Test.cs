using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Alpha.CommonClass.MyPrint;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyCalculus
    {

        public static void CalculusTest()
        {
            // Differential x^4 (x = 3)
            // Answer is 4x^3, 4(3)^3 = 108

            "[ Differential x^4 (x = 3) ]".Println();
            "Answer is 4x^3, 4(3)^3 = 108".Printlnln();


            "[Diff_Forward]".Println();
            double Differential_x_pow_4__3 = Diff_Forward(x => x * x * x * x, 3);
            "Use default(1e-3) step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            Differential_x_pow_4__3 = Diff_Forward(x => x * x * x * x, 3, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            "[Diff_Backward]".Println();
            Differential_x_pow_4__3 = Diff_Backward(x => x * x * x * x, 3);
            "Use default(1e-3) step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            Differential_x_pow_4__3 = Diff_Backward(x => x * x * x * x, 3, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            "[Diff_Midden]".Println();
            Differential_x_pow_4__3 = Diff_Midden(x => x * x * x * x, 3);
            "Use default(1e-3) step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            Differential_x_pow_4__3 = Diff_Midden(x => x * x * x * x, 3, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();


            "[Diff_FivePointStencil]".Println();
            Differential_x_pow_4__3 = Diff_FivePointStencil(x => x * x * x * x, 3);
            "Use default(1e-3) step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnln();

            Differential_x_pow_4__3 = Diff_FivePointStencil(x => x * x * x * x, 3, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Differential_x_pow_4__3).Println();
            ("Delta : " + (Differential_x_pow_4__3 - 108)).Printlnlnln();


            // Integral 3x^2 dx (4 to 10)
            // Answer is x^3, then (10)^3 - (4)^3 = 936

            "[ Integral 3x^2 dx (4 to 10) ]".Println();
            "Answer is x^3, then (10)^3 - (4)^3 = 936".Printlnln();


            "[Integral]".Println();
            double Integral_3x_pow_2__4_10 = Integral(4, 10, x => 3 * x * x);
            "Use default(1e-3) step".Println();
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            Integral_3x_pow_2__4_10 = Integral(4, 10, x => 3 * x * x, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            "[Integral_Sum_By_Trapezoidal]".Println();
            Integral_3x_pow_2__4_10 = Integral_Sum_By_Trapezoidal(x => 3 * x * x, 4, 10);
            "Use default(1e-3) step".Println();
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            Integral_3x_pow_2__4_10 = Integral_Sum_By_Trapezoidal(x => 3 * x * x, 4, 10, 1e-6);
            "Use 1e-6 step".Println();
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            "[Integral_Sum_By_Trapezoidal]".Println();
            Integral_3x_pow_2__4_10 = Integral_TrapezoidalRule(x => 3 * x * x, 4, 10);
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            "[Integral_SimpsonRule]".Println();
            Integral_3x_pow_2__4_10 = Integral_SimpsonRule(x => 3 * x * x, 4, 10);
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();


            "[Integral_BooleRule]".Println();
            Integral_3x_pow_2__4_10 = Integral_BooleRule(x => 3 * x * x, 4, 10);
            ("Answer : " + Integral_3x_pow_2__4_10).Println();
            ("Delta : " + (Integral_3x_pow_2__4_10 - 936)).Printlnln();

        }
    }
}
