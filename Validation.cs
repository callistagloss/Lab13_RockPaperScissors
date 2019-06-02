using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{

    class Validation
    {
        public static string GetIntFromUser(string message)
        {
            Console.Write(message);
            try
            {
                return Convert.ToString(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("I'm sorry. I didn't understand your input. Please select R, S, or P." + message);
                return GetIntFromUser(message);
            }
            catch (Exception)
            {
                Console.WriteLine("I'm sorry. I didn't understand your input." + message);

            }
            return GetIntFromUser(message);
        }

    }

}

    

