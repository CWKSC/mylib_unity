using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Alpha.CommonClass.MyCalculus;
using static MyLib_Csharp_Alpha.CommonClass.MyPrime;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyMath
    {

        public static void Test()
        {

            ConvertTest();

            PrimeTest();

            CalculusTest();



            // Here start the performance test //

            // Test Setting //
            MyTest.SetTestSetting();
            Console.WriteLine();

            PrimePerformanceTest();




        }



    }
}
