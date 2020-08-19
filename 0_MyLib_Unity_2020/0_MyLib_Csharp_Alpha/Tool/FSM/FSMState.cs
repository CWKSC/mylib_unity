using System;
using System.Collections.Generic;

namespace MyLib_Csharp_Alpha.Tool
{
    public class FSMState
    {
        public List<FSMConditionTransition> conditionTransitions = new List<FSMConditionTransition>();
        public List<FSMMessageTransition> messageTransitions = new List<FSMMessageTransition>();
        public Action enter = () => { };
        public Action update = () => { };
        public Action exit = () => { };
        public bool firstTimesEnter = true;

        public void Enter()
        {
            if (firstTimesEnter)
            {
                enter();
                firstTimesEnter = false;
            }
        }
        public void Exit()
        {
            exit();
            firstTimesEnter = true;
        }

        public void AddTransition(params FSMConditionTransition[] transition) => conditionTransitions.AddRange(transition);
        public void AddTransition(params FSMMessageTransition[] transition) => messageTransitions.AddRange(transition);

        public (bool, FSMState) CheckConditionTransition()
        {
            foreach (FSMConditionTransition transition in conditionTransitions)
            {
                if (transition.transitionCondition()) return (true, transition.targetState);
            }
            return (false, null);
        }

        public (bool, FSMState) CheckMessageTransition(string message)
        {
            foreach (FSMMessageTransition transition in messageTransitions)
            {
                if (transition.message == message) return (true, transition.targetState);
            }
            return (false, null);
        }

    }

}
