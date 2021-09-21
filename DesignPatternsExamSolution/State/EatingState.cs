using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamSolution.State
{
    class EatingState : State
    {
        public void PrintState ()
        {
            Console.WriteLine("Om nom nom!");
        }
    }
}
