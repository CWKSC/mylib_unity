using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Alpha.CommonClass.MyAction_ExtensionMethod;
using static MyLib_Csharp_Alpha.CommonClass.MyPrint;

namespace MyLib_Csharp_Alpha.CommonClass.MyType
{
    public partial class MyAction<T>
    {

        public static void Foo(int n, MyAction<int> myAction)
        {
            for (int i = 0; i < n; i++)
            {
                myAction.Invoke(i);
            }
        }
        public static void Foo(int n, Action<int> action) => Foo(n, (MyAction<int>)action);
        public static void Foo(int n, Action action)      => Foo(n, (MyAction<int>)action);



        public static void Test()
        {
            Foo(3, () => "0".Print()); ln(); // 000
            Foo(3, i => i.Print()); ln();    // 012
            Foo(3, "2"); ln();               // 222

            // Use adapter //
            Foo(3, _(() => "3".Print())); ln();    // 333
            Foo(3, _((int i) => i.Print())); ln();  // 012
            Foo(3, _("5")); ln();                  // 555
        }


    }
}
