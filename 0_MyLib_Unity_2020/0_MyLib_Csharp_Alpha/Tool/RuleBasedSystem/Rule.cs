using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MyLib_Csharp_Alpha.Tool
{
    public class Rule
    {
        public List<Fact> Ifs = new List<Fact>();
        public List<Fact> Thens = new List<Fact>();
        public bool isFired = false;

        public Rule(Fact If, Fact Then)
        {
            Ifs.Add(If);
            Thens.Add(Then);
        }
        public Rule(ITuple If, params Fact[] Then) => AddIfThen(If.ToArray<Fact>(), Then);


        public void AddIf(params Fact[] If) => Ifs.AddRange(If);
        public void AddThen(params Fact[] Then) => Thens.AddRange(Then);
        public void AddIfThen(Fact[] If, Fact[] Then)
        {
            AddIf(If);
            AddThen(Then);
        }

        public bool CheckIf(List<Fact> facts) => !Ifs.Except(facts).Any();
        public bool CheckIf(params Fact[] facts) => !Ifs.Except(facts).Any();

        public bool CheckThen(List<Fact> facts) => !Thens.Except(facts).Any();
        public bool CheckThen(params Fact[] facts) => !Thens.Except(facts).Any();

        public void PrintIf() => Ifs.JoinPrint((ele) => ele.Print(), " & ");
        public void PrintThen() => Thens.JoinPrint((ele) => ele.Print(), " & ");

    }

}
