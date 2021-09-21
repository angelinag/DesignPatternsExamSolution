using System;
using DesignPatternsExamSolution.Animal;
using DesignPatternsExamSolution.Observer;
using DesignPatternsExamSolution.State;

namespace DesignPatternsExamSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            Player player = new Player(horse);

            Console.WriteLine("Initial default state of animal: " + horse.GetCurrentState());

            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("To change horse state, please input 1 for Idle state, 2 for Eating state, 3 for Sleeping state: ");

                int newState = Int32.Parse(Console.ReadLine());
                if (newState == 1) horse.SetState(new IdleState());
                else if (newState == 2) horse.SetState(new EatingState());
                else if (newState == 3) horse.SetState(new SleepingState());
                else Console.WriteLine("Invalid input");

                player.Update();
            }
        }
    }
}
