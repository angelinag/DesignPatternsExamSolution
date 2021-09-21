using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamSolution.State
{
    class IdleState : State
    {
        public void PrintState()
        {
            Console.WriteLine("Doing nothing right now...");
        }
    }
}
