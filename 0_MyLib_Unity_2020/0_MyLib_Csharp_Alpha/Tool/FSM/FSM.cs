using System.Collections.Generic;

namespace MyLib_Csharp_Alpha.Tool
{

    public partial class FSM
    {
        public List<FSMState> states = new List<FSMState>();
        public FSMState currentState;

        public FSM() { }
        public FSM(FSMState initState, params FSMState[] state)
        {
            currentState = initState;
            states.Add(initState);
            states.AddRange(state);
        }
        public void AddState(params FSMState[] state) => states.AddRange(state);

        public void Update()
        {
            currentState.Enter();
            (var isTransition, var targetState) = currentState.CheckConditionTransition();
            if (isTransition)
            {
                currentState.Exit();
                currentState = targetState;
                currentState.Enter();
            }
            currentState.update();
        }

        public void DirectTransition(FSMState targetState)
        {
            currentState.Enter();
            currentState.Exit();
            currentState = targetState;
            currentState.Enter();
            currentState.update();
        }

        public void ReceiveMessage(string message)
        {
            (var isTransition, var targetState) = currentState.CheckMessageTransition(message);
            if (isTransition) DirectTransition(targetState);
        }

    }
}
