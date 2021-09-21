using System;
using System.Collections.Generic;
using System.Text;
using static System.ComponentModel.TypeConverter;


using static DesignPatternsExamSolution.Observer.Observer;
using static DesignPatternsExamSolution.Observer.Observable;
using static DesignPatternsExamSolution.State.State;

namespace DesignPatternsExamSolution
{
    class Player : Observer.Observer
    {
        private Observer.Observable animal;

        public Player(Observer.Observable animal)
        {
            this.animal = animal;
            this.animal.Subscribe(this);
        }

        public void Update()
        {
            State.State currentState = this.animal.GetCurrentState();
            Console.WriteLine("Observer has been notified of the new state: " + currentState);
        }
    }
}
