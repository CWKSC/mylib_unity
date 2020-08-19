using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateCode
    {



        public static void Test()
        {
            string template = "<0> <1> <2>\n";
            string[] set0 = { "12", "34" };
            string[] set1 = { "xx", "yy", "zz" };
            string[] set2 = { "aa", "bb", "cc", "dd" };

            Generate(template, set0, set1, set2).Println();

            string[][] group0 = { set0, set1 };
            string[][] group1 = { set2 };

            GenerateByGroup(template, group0, group1); // not finish
        }


    }
}
