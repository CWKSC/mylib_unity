using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{

    public partial class MyFunc<T, R>
    {
        public Func<T, R> func;

        public MyFunc(Func<T, R> func) => this.func = func;
        public MyFunc(Func<R> func) => this.func = _ => func();
        public MyFunc(R value) => func = _ => value;


        public R Invoke(T input) => func(input);

        public static implicit operator MyFunc<T, R>(Func<T, R> funcTR) => new MyFunc<T, R>(funcTR);
        public static implicit operator MyFunc<T, R>(Func<R> funcR) => new MyFunc<T, R>(funcR);
        public static implicit operator MyFunc<T, R>(R value) => new MyFunc<T, R>(value);
    }

}
