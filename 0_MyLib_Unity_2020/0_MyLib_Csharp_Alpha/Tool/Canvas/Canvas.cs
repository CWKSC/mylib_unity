using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.Tool
{
    public partial class Canvas
    {
        public List<Drawable> drawables;

        public void Draw()
        {
            Console.Clear();
            foreach (var drawable in drawables)
            {
                drawable.position.SetCursorPosition();
                drawable.Draw();
            }
        }

        public static void Test()
        {
            Canvas canvas = new Canvas();
        }


    }
}
