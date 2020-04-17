using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    class MyPhysics
    {
        public static float Momentum(float mass, float velocity)
        {
            return mass * velocity;
        }

        public static float KineticEnergy(float mass, float velocity)
        {
            return mass * velocity * velocity / 2.0f;
        }

        public static double? KE_mv(double? KE, double? m, double? v) =>
            KE == null ? m * v * v / 2.0f :
            m == null  ? 2 * KE / (v * v) :
            v == null  ? 2 * KE / m :
            null;

        public static float gravity = 9.81f;

        public static bool CircleCollision(Vector2 a, float r1, Vector2 b, float r2)
        {
            double distance = Vector2.Distance(a, b);
            return distance <= r1 + r2;
        }


        public static double? F_ma(double? F, double? m, double? a) => 
            F == null ? m * a : 
            m == null ? F / a : 
            a == null ? F / m : 
            null;
        /*
        if (F == null) return m * a;
        if (m == null) return F / a;
        if (a == null) return F / m;
        return null;
        */


    }
}
