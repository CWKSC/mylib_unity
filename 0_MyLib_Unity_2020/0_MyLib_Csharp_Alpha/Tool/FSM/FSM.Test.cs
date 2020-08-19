using System;

namespace MyLib_Csharp_Alpha.Tool
{
    public partial class FSM
    {

        public static void Test()
        {
            Console.WriteLine("=== Idle_Attack_Flee ===");
            Console.WriteLine();
            Test_Idle_Attack_Flee();

            Console.WriteLine("=== Start_Pause_Stop ===");
            Console.WriteLine();
            Test_Start_Resume_Pause_Stop();
        }

        public static void Test_Idle_Attack_Flee()
        {
            FSMState Idle = new FSMState()
            {
                enter = () => Console.WriteLine("Idle Enter"),
                update = () => Console.WriteLine("Idle Update"),
                exit = () => Console.WriteLine("Idle Exit")
            };
            FSMState Attack = new FSMState()
            {
                enter = () => Console.WriteLine("Attack Enter"),
                update = () => Console.WriteLine("Attack Update"),
                exit = () => Console.WriteLine("Attack Exit")
            };
            FSMState Flee = new FSMState()
            {
                enter = () => Console.WriteLine("Flee Enter"),
                update = () => Console.WriteLine("Flee Update"),
                exit = () => Console.WriteLine("Flee Exit")
            };

            float distance = 10;
            float hp = 100;

            FSMConditionTransition ToAttack = new FSMConditionTransition(Attack, () => distance < 5);
            FSMConditionTransition ToFlee = new FSMConditionTransition(Flee, () => hp < 30);
            Idle.AddTransition(ToAttack, ToFlee);
            Attack.AddTransition(ToFlee);

            FSMMessageTransition ToIdle = new FSMMessageTransition(Idle, "Idle");
            ToIdle.AddToState(Attack, Flee);

            FSM fsm = new FSM(Idle, Attack, Flee);

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[distance change to 3]");
            distance = 3;
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[hp change to 20]");
            hp = 20;
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Idle]");
            fsm.ReceiveMessage("Idle");
            Console.WriteLine();
        }


        public static void Test_Start_Resume_Pause_Stop()
        {
            FSMState Start = new FSMState()
            {
                enter = () => Console.WriteLine("Start Enter"),
                update = () => Console.WriteLine("Start Update"),
                exit = () => Console.WriteLine("Start Exit")
            };
            FSMState Resume = new FSMState()
            {
                enter = () => Console.WriteLine("Resume Enter"),
                update = () => Console.WriteLine("Resume Update"),
                exit = () => Console.WriteLine("Resume Exit")
            };
            FSMState Pause = new FSMState()
            {
                enter = () => Console.WriteLine("Pause Enter"),
                update = () => Console.WriteLine("Pause Update"),
                exit = () => Console.WriteLine("Pause Exit")
            };
            FSMState Stop = new FSMState()
            {
                enter = () => Console.WriteLine("Stop Enter"),
                update = () => Console.WriteLine("Stop Update"),
                exit = () => Console.WriteLine("Stop Exit")
            };

            FSMMessageTransition StartMessage_ToStart = new FSMMessageTransition(Start, "Start");
            FSMMessageTransition StartMessage_ToResume = new FSMMessageTransition(Resume, "Start");
            FSMMessageTransition PauseMessage_ToPause = new FSMMessageTransition(Pause, "Pause");
            FSMMessageTransition StopMessage_ToStop = new FSMMessageTransition(Stop, "Stop");
            Start.AddTransition(PauseMessage_ToPause, StopMessage_ToStop);
            Pause.AddTransition(StartMessage_ToResume);
            Resume.AddTransition(PauseMessage_ToPause, StopMessage_ToStop);
            Stop.AddTransition(StartMessage_ToStart);

            FSM fsm = new FSM(initState: Stop, Start, Resume, Pause);

            Console.WriteLine("[Test the correct flow]");
            Console.WriteLine();

            Console.WriteLine("[Update]");
            fsm.Update();
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Stop]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Pause]");
            fsm.ReceiveMessage("Pause");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Pause]");
            fsm.ReceiveMessage("Pause");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Stop]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("[Test the wrong flow / operation]");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start (Receive Start again, no change)]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Stop]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();
            Console.WriteLine("[ReceiveMessage Stop (Receive Stop again, no change)]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Pause]");
            fsm.ReceiveMessage("Pause");
            Console.WriteLine();
            Console.WriteLine("[ReceiveMessage Pause (Receive Pause again, no change)]");
            fsm.ReceiveMessage("Pause");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Start]");
            fsm.ReceiveMessage("Start");
            Console.WriteLine();

            Console.WriteLine("[ReceiveMessage Stop]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();
            Console.WriteLine("[ReceiveMessage Stop (Receive Stop again, no change)]");
            fsm.ReceiveMessage("Stop");
            Console.WriteLine();

        }


    }
}
