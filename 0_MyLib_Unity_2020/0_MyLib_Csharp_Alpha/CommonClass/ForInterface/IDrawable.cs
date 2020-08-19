using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public interface IDrawable
    {
        public void Draw();
        public void Draw<T>(T arg);
    }
}