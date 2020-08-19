using System;
using System.Collections.Generic;
using System.Text;

using static System.Math;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyCalculus
    {

        

        public static double Diff_Forward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x)) / deltaX ;

        public static double Diff_Backward(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x) - f(x - deltaX)) / deltaX;

        public static double Diff_Midden(Func<double, double> f, double x, double deltaX = 1e-7) => (f(x + deltaX) - f(x - deltaX)) / (2 * deltaX);


        public static double Diff_FivePointStencil(Func<double, double> f, double x, double deltaX = 1e-7) => 
            (-f(x + 2 * deltaX) + 8 * f(x + deltaX) - 8 * f(x - deltaX) + f(x - 2 * deltaX)) / (12 * deltaX);




        public static double Integral(double lower, double upper,
            Func<double, double> f, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i) * step;
            }
            return sum;
        }

        public static double Integral(double lower, double upper,
            Func<double, object[], double> f, object[] args = null,
            double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i, args) * step;
            }
            return sum;
        }

        public static double Integral<T>(double lower, double upper,
            Func<double, T, double> f, T otherParameter, 
            double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += f(i, otherParameter) * step;
            }
            return sum;
        }



        public static double Integral_Sum_By_Trapezoidal(Func<double, double> f,
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += (f(i) + f(i + step)) * step;
            }
            return sum / 2;
        }
        public static double Integral_Sum_By_Trapezoidal<T>(Func<double, T, double> f, T otherParameter,
            double lower, double upper, double step = 1e-3)
        {
            double sum = 0;
            for (double i = lower; i <= upper; i += step)
            {
                sum += (f(i, otherParameter) + f(i + step, otherParameter)) * step;
            }
            return sum / 2;
        }




        public static double Integral_TrapezoidalRule(Func<double, double> f,
            double lower, double upper) => (upper - lower) * (f(lower) + f(upper)) / 2;



        public static double Integral_SimpsonRule(Func<double, double> f, 
            double lower, double upper) =>
            (upper - lower) / 6 * (f(lower) + 4 * f((lower + upper) / 2) + f(upper));


        public static double Integral_BooleRule(Func<double, double> f,
           double lower, double upper)
        {
            double h = (upper - lower) / 4;
            return (2 * h / 45) * (7 * f(lower) + 32 * f(lower + h) + 12 * f(lower + 2 * h) + 32 * f(lower + 3 * h) + 7 * f(upper));
        }



    }
}
