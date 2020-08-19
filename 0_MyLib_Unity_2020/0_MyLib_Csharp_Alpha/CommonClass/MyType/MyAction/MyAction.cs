using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace MyLib_Csharp_Alpha.CommonClass.MyType
{
    public partial class MyAction<T>
    {
        public Action<T> action;

        public MyAction(Action<T> action) => this.action = action;
        public MyAction(Action action) => this.action = _ => action();

        public void Invoke(T input) => action(input);

        public static implicit operator MyAction<T>(Action<T> actionT) => new MyAction<T>(actionT);
        public static implicit operator MyAction<T>(Action action) => new MyAction<T>(action);
        public static implicit operator MyAction<T>(string value) => new MyAction<T>(value.ToPrintAction());


    }

}
