using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyPhysics
    {

        public static float gravity = 9.81f;


        public static float Momentum(float mass, float velocity) => mass * velocity;

        public static float KineticEnergy(float mass, float velocity) => mass * velocity * velocity / 2.0f;

        public static double KE_mv(out double KE,     double m,     double v) => KE = m * v * v / 2.0f;
        public static double KE_mv(    double KE, out double m,     double v) => m = 2 * KE / (v * v);
        public static double KE_mv(    double KE,     double m, out double v) => v = 2 * KE / m;



        public static bool CircleCollision(Vector2 a, float r1, Vector2 b, float r2) => (double)Vector2.Distance(a, b) <= r1 + r2;


        public static double F_ma(out double F,     double m,     double a) => F = m * a;
        public static double F_ma(    double F, out double m,     double a) => m = F / a;
        public static double F_ma(    double F,     double m, out double a) => a = F / m;


    }
}
