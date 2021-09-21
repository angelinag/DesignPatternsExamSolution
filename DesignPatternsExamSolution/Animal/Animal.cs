using System;
using System.Collections.Generic;
using System.Text;
using static DesignPatternsExamSolution.Observer.Observable;
using static DesignPatternsExamSolution.Observer.Observer;

namespace DesignPatternsExamSolution.Animal
{
    class Animal : Observer.Observable
    {
        private List<Observer.Observer> viewers;
        private State.State state;

        public Animal()
        {
            this.viewers = new List<Observer.Observer>();
            this.state = new State.IdleState();
        }

        public void Subscribe(Observer.Observer viewer)
        {
            this.viewers.Add(viewer);
        }

        public void Unsubscribe(Observer.Observer viewer)
        {
            this.viewers.Remove(viewer);
        }

        public void NotifyObservers()
        {
            foreach(Observer.Observer viewer in this.viewers)
            {
                viewer.Update();
            }
        }

        public void SetState(State.State state)
        {
            this.state = state;
        }

        public State.State GetCurrentState()
        {
            return this.state;
        }
    }
}
