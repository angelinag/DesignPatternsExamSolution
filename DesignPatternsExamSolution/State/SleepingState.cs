using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamSolution.State
{
    class SleepingState : State
    {
        public void PrintState()
        {
            Console.WriteLine("Zzzzzzzzzzz... Sweet dreams!");
        }
    }
}
