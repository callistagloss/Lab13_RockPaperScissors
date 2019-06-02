using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{
    class Rocky : Player
    {
        public Rocky(string Name) : base(Name)     //this calls constructor for name
        {

        }
        public override string GenerateRoShamBo()
        {
            return RPS.Rock;   //RPS is an object (class), and rock is a static property (like a method)
        }
    }
}
