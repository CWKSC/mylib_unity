using System;

namespace MyLib_Csharp_Alpha.Tool
{
    public partial class RuleBasedSystem
    {

        public static void Test()
        {

            Fact croaks = new Fact("it croaks");
            Fact eatsFlies = new Fact("it eats flies");
            Fact chirps = new Fact("it chirps");
            Fact sings = new Fact("it sings");
            Fact isFrog = new Fact("it is Frog");
            Fact isCanary = new Fact("it is Canary");
            Fact isGreen = new Fact("it is Green");
            Fact isYellow = new Fact("it is Yellow");

            Rule R1 = new Rule((croaks, eatsFlies), isFrog);
            Rule R2 = new Rule((chirps, sings), isCanary);
            Rule R3 = new Rule(isFrog, isGreen);
            Rule R4 = new Rule(isCanary, isYellow);

            RuleBasedSystem ruleBasedSystem = new RuleBasedSystem(R1, R2, R3, R4);

            Console.WriteLine("[Rules] :");
            ruleBasedSystem.PrintRule();
            Console.WriteLine();

            Console.WriteLine("[Knowns] :");
            ruleBasedSystem.PrintKnown();
            Console.WriteLine();

            Console.WriteLine("[AddFact croaks, eatsFlies]");
            ruleBasedSystem.AddFact(croaks, eatsFlies);
            Console.WriteLine();

            Console.WriteLine("[Knowns] :");
            ruleBasedSystem.PrintKnown();
            Console.WriteLine();

            Console.WriteLine("[ForwardChaining]");
            ruleBasedSystem.ForwardChaining();
            Console.WriteLine();

            Console.WriteLine("[Knowns] :");
            ruleBasedSystem.PrintKnown();
            Console.WriteLine();

            Console.WriteLine("[Rules] :");
            ruleBasedSystem.PrintRule();
            Console.WriteLine();

            Console.WriteLine("[Reset]");
            ruleBasedSystem.Reset();
            Console.WriteLine();

            Console.WriteLine("[Rules] :");
            ruleBasedSystem.PrintRule();
            Console.WriteLine();

            Console.WriteLine("[Knowns] :");
            ruleBasedSystem.PrintKnown();
            Console.WriteLine();

            Console.WriteLine("[AddFact croaks, eatsFlies]");
            ruleBasedSystem.AddFact(croaks, eatsFlies);
            Console.WriteLine();

            Console.WriteLine("[Knowns] :");
            ruleBasedSystem.PrintKnown();
            Console.WriteLine();

            Console.WriteLine("[BackwardChaining(isGreen)]");
            ruleBasedSystem.BackwardChaining(isGreen);
            Console.WriteLine();

            Console.WriteLine("[Rules] :");
            ruleBasedSystem.PrintRule();
            Console.WriteLine();

        }

    }
}
