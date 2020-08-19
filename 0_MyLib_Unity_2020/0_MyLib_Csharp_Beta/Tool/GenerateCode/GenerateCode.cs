using MyLib_Csharp_Beta.CommonMethod;
using MyLib_Csharp_Beta.ProgrammingPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyLib_Csharp_Beta.Tool
{
    public static partial class GenerateCode
    {

        //public static string Generate(string template, string[] set1, string[] set2)
        //{
        //    StringBuilder stringBuilder = new StringBuilder();
        //    set1.Loop((set1_ele, _) =>
        //        set2.Loop((set2_ele, _) =>
        //            stringBuilder.Append(
        //                template.Replace("<1>", set1_ele)
        //                        .Replace("<2>", set2_ele))
        //        )
        //    );
        //    return stringBuilder.ToString();
        //}


        public static int[] GetRowLengthArray<T>(this T[][] array)
        {
            int[] rowLength = new int[array.Length];
            rowLength.Map((ele, i) => array[i].Length);
            return rowLength;
        }

        public static string BuildString(Action<StringBuilder> action)
        {
            StringBuilder stringBuilder = new StringBuilder();
            action(stringBuilder);
            return stringBuilder.ToString();
        }

        public static string Generate(string template, params string[][] set) =>
            BuildString(builder =>
            {
                int[] refer = set.GetRowLengthArray();
                refer.CombinationLoop(indexs =>
                {
                    string temp = template;
                    indexs.Loop((index, i) => temp = temp.Replace($"<{i}>", set[i][index]) );
                    builder.Append(temp);
                });
            });

        public static string GenerateByGroup(string template, params string[][][] args) =>
            BuildString(builder =>
            {
                
                //int[] refer = new int[args.Length];
                ////refer.Map((ele, i) => args[i].set.Length);
                //refer.CombinationLoop(indexs =>
                //{
                //    string temp = template;
                //    //indexs.Loop((index, i) => temp = temp.Replace($"<{i}>", set[i][index]));
                //    builder.Append(temp);
                //});
            });



    }
}
