using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{
    class User : Player
    {
        public User(string Name) : base(Name)
        {
            
        }

        public override string GenerateRoShamBo()
        {
            Console.WriteLine("Rock, paper, or scissors? (R/P/S):");
            string userInput = Console.ReadLine().ToUpper();
            if (userInput == "R")
            {
                return RPS.Rock;
            }
            else if (userInput == "P")
            {
                return RPS.Paper;
            }
            else if (userInput == "S")
            {
                return RPS.Scissors;
            }
            else
            {
                Console.WriteLine("I'm sorry you live under a rock and don't know how to play.");
            }
            return null;
        }
    }
}
