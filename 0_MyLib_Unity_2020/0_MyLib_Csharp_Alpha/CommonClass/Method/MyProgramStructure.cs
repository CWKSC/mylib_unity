using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static partial class ProgrammaticProgram
    {

        public static bool If(this bool condition, Action action)
        {
            if (condition) action();
            return condition;
        }

        public static bool Else(this bool condition, Action action) => 
            If(!condition, action);


        public static T Delcare<T>(out T variable, T init = default) => variable = init;


        public static ReturnValue<T> Return<T>(T expression) => new ReturnValue<T>(expression);

        public static ReturnValue<MyVoid> Return() => new ReturnValue<MyVoid>(new MyVoid());
    }


    public class ReturnValue<T>
    {
        public T returnValue;

        public ReturnValue(T returnValue)
        {
            this.returnValue = returnValue;
        }
    }

}
