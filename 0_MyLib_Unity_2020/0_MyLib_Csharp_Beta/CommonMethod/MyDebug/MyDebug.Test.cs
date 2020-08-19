#define MyDebug

using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.CommonMethod
{
    public static partial class MyDebug
    {

        private static void A()
        {
            "Into A".Println();
            LogMethod(); // same to LogCaller()
        }

        private static void B()
        {
            "Into B".Println();
            LogCaller(); // same to LogMethod()
        }

        public static void Test()
        {
            // On the top you can see "//#define MyDebug"
            // Uncomment it then the following function will call
            // So when #define MyDebug is define, the following function will call
            // when MyDebug is not define, the following function will not call
            // It is a switch for you to control debug log or function

            Log("123\n");
            Logln("456");

            Call(() => "789".Println());

            Call(A);
            Call(B);

            A();
            B();

        }
        /* When MyDebug is not define
        Into A
        Into B

        // When MyDebug is define //
        123
        456
        789
        Into A
        A
        Into B
        B
        Into A
        A
        Into B
        B
        */

    }
}
