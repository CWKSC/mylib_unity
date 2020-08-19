using System;

namespace MyLib_Csharp_Alpha.Tool
{
    public abstract class FSMTransition
    {
        public FSMState targetState;
        public FSMTransition(FSMState targetState) => this.targetState = targetState;
    }

    public class FSMConditionTransition : FSMTransition
    {
        public Func<bool> transitionCondition;
        public FSMConditionTransition(FSMState targetState, Func<bool> transitionCondition) : base(targetState) => this.transitionCondition = transitionCondition;
        public void AddToState(params FSMState[] states)
        {
            foreach (FSMState state in states)
            {
                state.AddTransition(this);
            }
        }

    }


    public class FSMMessageTransition : FSMTransition
    {
        public string message;
        public FSMMessageTransition(FSMState targetState, string message) : base(targetState) => this.message = message;
        public void AddToState(params FSMState[] states)
        {
            foreach(FSMState state in states)
            {
                state.AddTransition(this);
            }
        }
    }



}
