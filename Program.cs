using System;
using System.Collections.Generic;

namespace Lab13RPSBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Rocky r = new Rocky("Balboa");    //calling Rocky and giving him a name
            //    Console.WriteLine($"{r.Name} throws {r.GenerateRoShamBo()}");

            //    Random rando = new Random();
            //    Randy marsh = new Randy("Randy Marsh", rando);   //Randy is random so his constructor is different than Rocky's

            //    for(int i = 0; i < 10; i++)
            //    {
            //        Console.WriteLine($"{marsh.Name} throws {marsh.GenerateRoShamBo()}");
            //    }

            

            //User user = new User("Chewy");
            //user.GenerateRoShamBo();
            RPSApp ra = new RPSApp();   //calls it
            ra.Menu();
            ra.Run();   //runs it
        }
    }
}
