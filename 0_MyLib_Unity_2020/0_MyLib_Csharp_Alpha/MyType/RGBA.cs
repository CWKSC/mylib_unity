using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.MyType
{
    public partial class RGBA
    {
        public int r = 255;
        public int g = 255;
        public int b = 255;
        public int a = 255;

        public void Invert()
        {
            r = 255 - r;
            g = 255 - g;
            b = 255 - b;
        }

    }
}
