using System;

namespace MyLib_Csharp_Alpha.Tool
{
    public class FSM_Start_Resume_Pause_Stop : FSM
    {

        public FSM fsm;
        public FSMState Start = new FSMState();
        public FSMState Resume = new FSMState();
        public FSMState Pause = new FSMState();
        public FSMState Stop = new FSMState();

        public FSM_Start_Resume_Pause_Stop()
        {
            FSMMessageTransition StartMessage_ToStart = new FSMMessageTransition(Start, "Start");
            FSMMessageTransition StartMessage_ToResume = new FSMMessageTransition(Resume, "Start");
            FSMMessageTransition PauseMessage_ToPause = new FSMMessageTransition(Pause, "Pause");
            FSMMessageTransition StopMessage_ToStop = new FSMMessageTransition(Stop, "Stop");
            Start.AddTransition(PauseMessage_ToPause, StopMessage_ToStop);
            Pause.AddTransition(StartMessage_ToResume);
            Resume.AddTransition(PauseMessage_ToPause, StopMessage_ToStop);
            Stop.AddTransition(StartMessage_ToStart);

            AddState(Start, Resume, Pause, Stop);
            currentState = Stop;
        }

        public new static void Test()
        {
            FSM_Start_Resume_Pause_Stop fsm = new FSM_Start_Resume_Pause_Stop();
            fsm.Start.enter = () => Console.WriteLine("Start Enter");
            fsm.Start.update = () => Console.WriteLine("Start Update");
            fsm.Start.exit = () => Console.WriteLine("Start Exit");

            fsm.Resume.enter = () => Console.WriteLine("Resume Enter");
            fsm.Resume.update = () => Console.WriteLine("Resume Update");
            fsm.Resume.exit = () => Console.WriteLine("Resume Exit");

            fsm.Pause.enter = () => Console.WriteLine("Pause Enter");
            fsm.Pause.update = () => Console.WriteLine("Pause Update");
            fsm.Pause.exit = () => Console.WriteLine("Pause Exit");

            fsm.Stop.enter = () => Console.WriteLine("Stop Enter");
            fsm.Stop.update = () => Console.WriteLine("Stop Update");
            fsm.Stop.exit = () => Console.WriteLine("Stop Exit");

            Console.WriteLine("[ FSM_Start_Pause_Stop ]");
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
