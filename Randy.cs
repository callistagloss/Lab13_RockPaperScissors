using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{
    class Randy : Player  //don't forget to implement abstract class if there's an error
    {   
        public Random R { get; set; }  //random property     declaring variable

        public Randy(string Name, Random R) :base(Name) //constructor for Randy, Random R = parameter       initializing variable
                                                        //base points to parent, we are getting the name up to the parent
        {
            this.R = R;
        }
        public override string GenerateRoShamBo()
        {
            int choice = R.Next(0, 3);
            List<string> rpsValues = new List<string>() { RPS.Rock, RPS.Paper, RPS.Scissors };
            return rpsValues[choice];
        }
    }
}
