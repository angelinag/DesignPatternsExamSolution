using System;
using System.Collections.Generic;
using System.Text;
using static DesignPatternsExamSolution.State.State;

namespace DesignPatternsExamSolution.Observer
{
    interface Observable
    {
        public void Subscribe(Observer viewer);
        public void Unsubscribe(Observer viewer);
        public void NotifyObservers();
        public void SetState(State.State state);
        State.State GetCurrentState();

    }
}
