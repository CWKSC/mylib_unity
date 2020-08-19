using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public class MultipleInheritance<A, B>
    {
        public A a;
        public B b;

        public static implicit operator A(MultipleInheritance<A, B> thisObject) => thisObject.a;
        public static implicit operator B(MultipleInheritance<A, B> thisObject) => thisObject.b;
    }

    public class MultipleInheritance<A, B, C>
    {
        public A a;
        public B b;
        public C c;

        public static implicit operator A(MultipleInheritance<A, B, C> thisObject) => thisObject.a;
        public static implicit operator B(MultipleInheritance<A, B, C> thisObject) => thisObject.b;
        public static implicit operator C(MultipleInheritance<A, B, C> thisObject) => thisObject.c;
    }



}
