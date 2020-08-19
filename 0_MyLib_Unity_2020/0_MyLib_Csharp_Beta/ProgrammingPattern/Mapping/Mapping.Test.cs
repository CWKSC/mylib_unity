using MyLib_Csharp_Beta.CommonMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Mapping
    {

        public static void Test()
        {
            string[] dataSet = { "a", "b", "c", "d" };

            int[] mapIndex = { 1, 2, 3 };

            ("Origin:  " + dataSet.ToStr()).Println();
            ("Map_new: " + dataSet.Map_new((ele, _) => ele + "e").ToStr()).Println();
            ("Origin:  " + dataSet.ToStr()).Printlnln();

            ("Origin: " + dataSet.ToStr()).Println();
            ("Map:    " + dataSet.Map((ele, _) => ele + "e").ToStr()).Println();
            ("Origin: " + dataSet.ToStr()).Printlnln();

        }

    }
}
