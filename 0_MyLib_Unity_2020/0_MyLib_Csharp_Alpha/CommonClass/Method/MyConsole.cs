using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static class MyConsole
    {

        public static void SetCursorPosition(this (int x, int y) position) => 
            Console.SetCursorPosition(position.x, position.y);

        public static void MoveCursorRelative(int x, int y) => 
            Console.SetCursorPosition(Console.CursorLeft + x, Console.CursorTop + y);

        public static void MoveCursorUp(int offset = 1) => MoveCursorRelative(0, -offset);
        public static void MoveCursorDown(int offset = 1) => MoveCursorRelative(0, offset);
        public static void MoveCursorLeft(int offset = 1) => MoveCursorRelative(-offset, 0);
        public static void MoveCursorRight(int offset = 1) => MoveCursorRelative(offset, 0);

        public static void MoveCursorUpLeft(int offset = 1) => MoveCursorRelative(-offset, -offset);
        public static void MoveCursorUpRight(int offset = 1) => MoveCursorRelative(offset, -offset);

        public static void MoveCursorDownLeft(int offset = 1) => MoveCursorRelative(-offset, offset);
        public static void MoveCursorDownRight(int offset = 1) => MoveCursorRelative(offset, offset);


        public static void Test()
        {
            (1, 1).SetCursorPosition();
            Thread.Sleep(500);
            MoveCursorUp();
            "W".Print_dontMoveCursor();
            Thread.Sleep(500);
            MoveCursorDown();
            "S".Print_dontMoveCursor();
            Thread.Sleep(500);
            MoveCursorLeft();
            "A".Print_dontMoveCursor();
            Thread.Sleep(500);
            MoveCursorRight(2);
            "D".Print_dontMoveCursor();

            Thread.Sleep(500);
            (4, 0).SetCursorPosition();
            new string[]{
                " xxxxx   x     x  x   xx   xxxxx   xxxxx",
                "x     x  x     x  x xx    x       x     ",
                "x        x  x  x  xx       xxxx   x     ",
                "x     x  x x x x  x xx         x  x     ",
                " xxxxx   xx   xx  x   xx  xxxxx    xxxxx"}.Print();
        }


    }
}
