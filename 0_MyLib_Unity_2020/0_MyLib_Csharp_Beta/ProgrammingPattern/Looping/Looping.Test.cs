using MyLib_Csharp_Beta.CommonMethod;

namespace MyLib_Csharp_Beta.ProgrammingPattern
{
    public static partial class Looping
    {

        private static void PrintI(int i) => (i + " ").Print();

        public static void Test()
        {
            // (start, end, step) //
            (0, 17, 3).Loop(PrintI).ln();
            (50, 100, 7).Loop(i => (i + " ").Print()).ln();
            (30, 50, 1).Loop(i => (i + " ").Print(), i => i % 2 == 0).lnln();

            // (start, end) //
            (0, 5).Loop(PrintI).ln();
            (4, 9).Loop(i => (i + " ").Print()).ln();
            (10, 30).Loop(i => (i + " ").Print(), i => i % 5 == 0).lnln();

            // times //
            3.Loop(PrintI).ln();
            5.Loop(i => (i + " ").Print()).ln();
            14.Loop(i => (i + " ").Print(), i => i % 4 == 0).lnln();

            // T[] //
            int[] array = { 3, 6, 2, 1, 8 };
            array.Loop(ele => (ele + " ").Print()).ln();
            array.Loop((ele, i) => (ele, i).Print()).ln();
            array.Loop((ele, i) => (ele, i).Print(), (ele, _) => ele % 2 == 0).lnln();

            (int x, int y)[] points = { (1, 2), (4, 5), (7, 8), (10, 11) };
            points.Loop(ele => $"({ele.x}, {ele.y}) ".Print());
        }
        /*
        0 3 6 9 12 15
        50 57 64 71 78 85 92 99
        30 32 34 36 38 40 42 44 46 48 50

        0 1 2 3 4 5
        4 5 6 7 8 9
        10 15 20 25 30

        0 1 2
        0 1 2 3 4
        0 4 8 12

        3 6 2 1 8
        (3, 0)(6, 1)(2, 2)(1, 3)(8, 4)
        (6, 1)(2, 2)(8, 4)

        (1, 2) (4, 5) (7, 8) (10, 11)
        */

    }
}
