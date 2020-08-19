using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyPrime
    {
        public static void PrimeTest()
        {
            MyTest.TestPrimeTestCorrect(IsPrime_normal);
            MyTest.TestPrimeTestCorrect("IsPrime_short", (i) => IsPrime_short((short)i));
            MyTest.TestPrimeTestCorrect("IsPrime_short_v2", (i) => IsPrime_short_v2((short)i));
            MyTest.TestPrimeTestCorrect(IsPrime_int);
            MyPrint.ln();
        }

    }
}
