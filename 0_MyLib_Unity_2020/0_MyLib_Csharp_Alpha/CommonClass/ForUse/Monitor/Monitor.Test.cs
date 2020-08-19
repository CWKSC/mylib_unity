using System;
using System.Collections.Generic;
using System.Text;

using static MyLib_Csharp_Alpha.CommonClass.MyPrint;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public class Monitor
    {

        public static void Test()
        {
            Monitor<int> monitor = new Monitor<int>();

            monitor.IsChange(1).Println();
            monitor.IsChange(1).Println();
            monitor.IsChange(1).Println();
            ln();
            monitor.IsChange(2).Println(); // value change
            monitor.IsChange(2).Println();
            monitor.IsChange(2).Println();
            ln();
            monitor.IsChange(3).Println(); // value change
            monitor.IsChange(3).Println();
            monitor.IsChange(3).Println();
            ln();

            "[Fast Version : Monitor_Fast, you must init value in constructor]".Printlnln();

            Monitor_Fast<int> monitor_Fast = new Monitor_Fast<int>(1);

            monitor_Fast.IsChange(1).Println();
            monitor_Fast.IsChange(1).Println();
            monitor_Fast.IsChange(1).Println();
            ln();
            monitor_Fast.IsChange(2).Println();  // value change
            monitor_Fast.IsChange(2).Println();
            monitor_Fast.IsChange(2).Println();
            ln();
            monitor_Fast.IsChange(3).Println();  // value change
            monitor_Fast.IsChange(3).Println();
            monitor_Fast.IsChange(3).Println();

        }


    }
}
