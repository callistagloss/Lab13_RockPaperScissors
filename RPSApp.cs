using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{
    class RPSApp
    {
        Validation v = new Validation();

        Random rando = new Random();

        

        public void Menu()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hi {0}!", userName);
            Console.WriteLine();
        }
        public void Run()
        {
            
            Rocky r = new Rocky("Chewy"); 
            Player opponent = new Rocky("error");
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Please select an opponent: Rocky or Randy.");
                string input = Console.ReadLine();
                //string y = Validation.GetIntFromUser(input);
               Validation.GetIntFromUser(input);

                if (input == "Rocky")
                {
                    opponent = new Rocky("The Rock");
                    run = false;
                }
                else if (input == "Randy")
                {
                    opponent = new Randy("Randy Marsh", rando);  //calls global variable for random
                    run = false;
                }
                else
                {
                    Console.WriteLine("Sorry, I didn't understand that. Please try again.");
                }
            }
            User user = new User("Chewy");
            string userRPS = user.GenerateRoShamBo();
            string opponentRPS = opponent.GenerateRoShamBo();

            Console.WriteLine($"{user.Name}: {userRPS}"); 
            Console.WriteLine($"{opponent.Name}: {opponentRPS}");
            if (userRPS == opponentRPS)
            {
                Console.WriteLine("Draw!");
            }

            else if (userRPS == RPS.Rock)
            {
                if (opponentRPS == RPS.Paper)
                {
                    Console.WriteLine("Opponent wins!");
                }
                else if (opponentRPS == RPS.Scissors)
                {
                    Console.WriteLine("You win!");
                }
            }
            else if (userRPS == RPS.Scissors)
            {
                if (opponentRPS == RPS.Paper)
                {
                    Console.WriteLine("You win!");
                }
                else if (opponentRPS == RPS.Rock)
                {
                    Console.WriteLine("Opponent wins!");
                }
            
            }
            else if (userRPS == RPS.Paper)
            {
                if (opponentRPS == RPS.Rock)
                {
                    Console.WriteLine("You win!");
                }
                else if (opponentRPS == RPS.Scissors)
                {
                    Console.WriteLine("Opponent wins!");
                }
            }

            Console.WriteLine();
            Continue();
        }
        public Boolean Continue()
         {
                Console.WriteLine("Play again? y/n");
                string input = Console.ReadLine();
                Boolean go = false;
                input.ToLower();

                if (input == "n")
                {
                    Console.WriteLine("Goodbye.");
                    go = false;
                }
                else if (input == "y")
                {
                    go = true;
                    Run();
                }
                else
                {
                    Console.WriteLine("I'm sorry. I didn't understand your input. Let's try that again.");
                    go = Continue();

                }
                return go;
            }

        }
    }

