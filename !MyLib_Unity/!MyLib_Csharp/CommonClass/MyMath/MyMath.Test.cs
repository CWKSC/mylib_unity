using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    public partial class MyMath
    {

        public static void Test()
        {

            // Trigonometric functions //
            Console.WriteLine("Sin(30) = " + Sin(30));
            Console.WriteLine("Cos(60) = " + Sin(30));
            Console.WriteLine("Tan(45) = " + Sin(30));
            Console.WriteLine();

            // Cartesian to Polar //
            Console.WriteLine("CartesianToPolar_Radians (1, 1) = " + CartesianToPolar_Radians(1, 1));
            Console.WriteLine("CartesianToPolar_PI      (1, 1) = " + CartesianToPolar_PI(1, 1));
            Console.WriteLine("CartesianToPolar_Degrees (1, 1) = " + CartesianToPolar_Degrees(1, 1));
            Console.WriteLine("CartesianToPolar_Gradians(1, 1) = " + CartesianToPolar_Gradians(1, 1));
            Console.WriteLine("CartesianToPolar_Turns   (1, 1) = " + CartesianToPolar_Turns(1, 1));
            Console.WriteLine();

            // Cartesian to Polar (start at Up) //
            Console.WriteLine("CartesianToPolar_startAtUp_Radians (1, 1) = " + CartesianToPolar_startAtUp_Radians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtUp_PI      (1, 1) = " + CartesianToPolar_startAtUp_PI(1, 1));
            Console.WriteLine("CartesianToPolar_startAtUp_Degrees (1, 1) = " + CartesianToPolar_startAtUp_Degrees(1, 1));
            Console.WriteLine("CartesianToPolar_startAtUp_Gradians(1, 1) = " + CartesianToPolar_startAtUp_Gradians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtUp_Turns   (1, 1) = " + CartesianToPolar_startAtUp_Turns(1, 1));
            Console.WriteLine();

            // Cartesian to Polar (start at Left) //
            Console.WriteLine("CartesianToPolar_startAtLeft_Radians (1, 1) = " + CartesianToPolar_startAtLeft_Radians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtLeft_PI      (1, 1) = " + CartesianToPolar_startAtLeft_PI(1, 1));
            Console.WriteLine("CartesianToPolar_startAtLeft_Degrees (1, 1) = " + CartesianToPolar_startAtLeft_Degrees(1, 1));
            Console.WriteLine("CartesianToPolar_startAtLeft_Gradians(1, 1) = " + CartesianToPolar_startAtLeft_Gradians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtLeft_Turns   (1, 1) = " + CartesianToPolar_startAtLeft_Turns(1, 1));
            Console.WriteLine();

            // Cartesian to Polar (start at Down) //
            Console.WriteLine("CartesianToPolar_startAtDown_Radians (1, 1) = " + CartesianToPolar_startAtDown_Radians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtDown_PI      (1, 1) = " + CartesianToPolar_startAtDown_PI(1, 1));
            Console.WriteLine("CartesianToPolar_startAtDown_Degrees (1, 1) = " + CartesianToPolar_startAtDown_Degrees(1, 1));
            Console.WriteLine("CartesianToPolar_startAtDown_Gradians(1, 1) = " + CartesianToPolar_startAtDown_Gradians(1, 1));
            Console.WriteLine("CartesianToPolar_startAtDown_Turns   (1, 1) = " + CartesianToPolar_startAtDown_Turns(1, 1));
            Console.WriteLine();

            // Degrees Convert //
            Console.WriteLine("DegreesToRadians    (30) = " + DegreesToRadians(30));
            Console.WriteLine("DegreesToPI         (30) = " + DegreesToPI(30));
            Console.WriteLine("DegreesToGradians   (30) = " + DegreesToGradians(30));
            Console.WriteLine("DegreesToTurns      (30) = " + DegreesToTurns(30));
            Console.WriteLine("DegreesToVector2    (30) = " + DegreesToVector2(30));
            Console.WriteLine("DegreesToUnitVector2(30) = " + DegreesToUnitVector2(30));
            Console.WriteLine("DegreesToList       (30) = [" + DegreesToList(30)[0] + ", " + DegreesToList(30)[1] + "]");
            Console.WriteLine("DegreesToUnitList   (30) = [" + DegreesToUnitList(30)[0] + ", " + DegreesToUnitList(30)[1] + "]");
            Console.WriteLine();

            // Here start the performance test //

            // Test Setting //
            MyTest.SetTestSetting();
            Console.WriteLine();

            // Prime Test //
            MyTest.TestPrimeTestCorrect(IsPrime_normal);
            MyTest.TestPrimeTestCorrect("IsPrime_short", (i) => IsPrime_short((short)i));
            MyTest.TestPrimeTestCorrect("IsPrime_short_v2", (i) => IsPrime_short_v2((short)i));
            MyTest.TestPrimeTestCorrect(IsPrime_int);
            Console.WriteLine();

            // Prime Test (short) //
            // MyMath.IsPrime_short() //
            MyTest.TestExecutionTime("IsPrime_short", () =>
            {
                for (short i = 0; i < short.MaxValue; i++)
                {
                    if (IsPrime_short(i))
                    {
                        //Console.WriteLine(i + " is Prime number");
                    }
                }
            }, 1000);
            // MyMath.IsPrime_short_v2() //
            MyTest.TestExecutionTime("IsPrime_short_v2", () =>
            {
                for (short i = 0; i < short.MaxValue; i++)
                {
                    if (IsPrime_short_v2(i))
                    {
                        //Console.WriteLine(i + " is Prime number");
                    }
                }
            }, 1000);
            // Your IsPrime in short //
            MyTest.TestExecutionTime("IsPrime_normal", () =>
            {
                // Try you IsPrime here
                // Test the execution time
                // and you can compare to performance of MyMath.IsPrime_short below
                for (short i = 0; i < short.MaxValue; i++)
                {
                    if (IsPrime_normal(i))
                    {
                        //Console.WriteLine(i + " is Prime number");
                    }
                }
            }, 1000);
            Console.WriteLine();


            // MyMath.IsPrime_int()
            MyTest.TestExecutionTime("IsPrime_int", () =>
            {
                for (int i = 2147000000; i < int.MaxValue; i++)
                {
                    if (IsPrime_int(i))
                    {
                        //Console.WriteLine(i + " is Prime number");
                    }
                }
            });
            // Your IsPrime in int
            MyTest.TestExecutionTime("IsPrime_normal", () =>
            {
                // Try you IsPrime here
                // Test the execution time
                // and you can compare to performance of MyMath.IsPrime_int below
                for (int i = 2147000000; i < int.MaxValue; i++)
                {
                    if (IsPrime_normal(i))
                    {
                        //Console.WriteLine(i + " is Prime number");
                    }
                }
            });
            Console.WriteLine();



        }



    }
}
