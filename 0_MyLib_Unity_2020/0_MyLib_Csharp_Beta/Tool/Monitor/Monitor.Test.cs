
using static MyLib_Csharp_Beta.CommonMethod.Printing;

namespace MyLib_Csharp_Beta.Tool
{
    public class Monitor
    {

        public static void Test()
        {
            "Test monitor int".Printlnln();
            Monitor<int> monitor = new Monitor<int>(1);

            monitor.IsChange(2).Println(); // value change, return ture
            monitor.IsChange(2).Println(); // false
            monitor.IsChange(2).Printlnln();

            monitor.IsChange(3).Println(); // value change, return ture
            monitor.IsChange(3).Println(); // false
            monitor.IsChange(3).Printlnln();

            monitor.IsChange(4).Println(); // value change, return ture
            monitor.IsChange(4).Println(); // false
            monitor.IsChange(4).Printlnln();


            "Test monitor object".Printlnln();
            object a = new object();
            object b = new object();
            Monitor<object> monitorObject = new Monitor<object>(a);

            monitorObject.IsChange(b).Println(); // value change, return ture
            monitorObject.IsChange(b).Println(); // false
            monitorObject.IsChange(b).Printlnln();

            monitorObject.IsChange(a).Println(); // value change, return ture
            monitorObject.IsChange(a).Println(); // false
            monitorObject.IsChange(a).Printlnln();

        }
        /* Output
        Test monitor int

        True
        False
        False

        True
        False
        False

        True
        False
        False

        Test monitor object

        True
        False
        False

        True
        False
        False
        */


    }
}
