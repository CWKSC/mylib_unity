using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public class Monitor<T> 
    {
        public T target;
        public bool firstTime = true;

        public Monitor() { }
        public Monitor(T init)
        {
            target = init;
            firstTime = false;
        }

        public bool IsChange(T input)
        {
            if (firstTime)
            {
                target = input;
                firstTime = false;
                return false;
            }
            bool result = !target.Equals(input);
            target = input;
            return result;
        }

    }


    public class Monitor_Fast<T>
    {
        public T target;
        public Monitor_Fast(T init) => target = init;
        public bool IsChange(T input)
        {
            bool result = !target.Equals(input);
            target = input;
            return result;
        }
    }




}
