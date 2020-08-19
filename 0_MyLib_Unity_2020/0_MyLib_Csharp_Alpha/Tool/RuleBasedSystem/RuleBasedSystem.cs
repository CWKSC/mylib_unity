using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLib_Csharp_Alpha.Tool
{

    public partial class RuleBasedSystem
    {
        public List<Rule> rules = new List<Rule>();
        public List<Fact> knowns = new List<Fact>();

        public RuleBasedSystem(params Rule[] rule) => rules.AddRange(rule);

        public void AddRule(params Rule[] rule) => rules.AddRange(rule);
        public void AddFact(params Fact[] facts) => knowns.AddRange(facts);

        public void Reset()
        {
            rules.ForEach(ele => ele.isFired = false);
            knowns.Clear();
        }

        public void ForwardChaining()
        {
            foreach(var rule in rules)
            {
                //rule.PrintIf();
                //Console.WriteLine();
                if (rule.CheckIf(knowns))
                {
                    //Console.WriteLine("Fired");
                    rule.isFired = true;
                    knowns.AddRange(rule.Thens);
                }
                //Console.WriteLine();
            }
        }

        public void BackwardChaining(params Fact[] goal)
        {
            List<Fact> ReasoningChain = new List<Fact>();
            Fact[] subGoal = goal;
            for (int i = rules.Count - 1; i >= 0; i--)
            {
                Rule rule = rules[i];
                //rule.PrintIf();
                //Console.WriteLine();
                if (rule.CheckThen(subGoal))
                {
                    //Console.WriteLine("Fired");
                    rule.isFired = true;
                    if (!rule.Ifs.Except(knowns).Any()) break;
                    ReasoningChain.AddRange(rule.Ifs);
                    subGoal = rule.Ifs.ToArray();
                }
                //Console.WriteLine();
            }
            PrintKnown();

            ReasoningChain.Reverse();
            foreach (var ele in ReasoningChain)
            {
                Console.WriteLine(" -> " + ele.name);
            }

            Console.WriteLine(" -> " + goal[0]);
            for (int i = 1; i < goal.Length; i++)
            {
                Console.WriteLine(" & " + goal[i]);
            }

        }



        public void PrintRule()
        {
            foreach (var rule in rules)
            {
                if (rule.isFired) { Console.Write("[Fired] "); }
                Console.Write("If "); rule.PrintIf();
                Console.Write(" Then "); rule.PrintThen();
                Console.WriteLine();
            }
        }

        public void PrintKnown()
        {
            foreach(var known in knowns)
            {
                Console.WriteLine(known.name);
            }
        }

    }


}
