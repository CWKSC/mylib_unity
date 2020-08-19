using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public class ImplicitWrapper<T>
    {
        public T value;
        private ImplicitWrapper(T value) => this.value = value;

        public static implicit operator ImplicitWrapper<T>(T value) => new ImplicitWrapper<T>(value);
        public static implicit operator T(ImplicitWrapper<T> implicitWrapper) => implicitWrapper.value;
    }

    // Reference: https://www.codeproject.com/Questions/141385/typedef-in-C

}
