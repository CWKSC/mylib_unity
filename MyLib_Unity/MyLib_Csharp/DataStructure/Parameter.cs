using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp.DataStructure
{
    public class Parameter<P1>
    {
        public P1 p1;

        public Parameter(P1 p1) => this.p1 = p1;
    }

    public class Parameter<P1, P2>
    {
        public P1 p1;
        public P2 p2;

        public Parameter(P1 p1, P2 p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
    }

    public class Parameter<P1, P2, P3>
    {
        public P1 p1;
        public P2 p2;
        public P3 p3;

        public Parameter(P1 p1, P2 p2, P3 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
    }

    public class Parameter<P1, P2, P3, P4>
    {
        public P1 p1;
        public P2 p2;
        public P3 p3;
        public P4 p4;

        public Parameter(P1 p1, P2 p2, P3 p3, P4 p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }
    }

    public class Parameter<P1, P2, P3, P4, P5>
    {
        public P1 p1;
        public P2 p2;
        public P3 p3;
        public P4 p4;
        public P5 p5;

        public Parameter(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
        }
    }

    public class Parameter<P1, P2, P3, P4, P5, P6>
    {
        public P1 p1;
        public P2 p2;
        public P3 p3;
        public P4 p4;
        public P5 p5;
        public P6 p6;

        public Parameter(P1 p1, P2 p2, P3 p3, P4 p4, P5 p5, P6 p6)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
            this.p5 = p5;
            this.p6 = p6;
        }
    }

}
