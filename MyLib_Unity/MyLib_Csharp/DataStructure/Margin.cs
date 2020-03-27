using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    class Margin
    {
        public float top;
        public float bottom;
        public float left;
        public float right;

        public Margin(float length = 0.0f)
        {
            top = bottom = left = right = length;
        }
        public Margin(float top, float bottom, float left, float right)
        {
            this.top = top;
            this.bottom = bottom;
            this.left = left;
            this.right = right;
        }
    }
}
