using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13RPSBreakout
{
    abstract class Player
    {
        public string Name { get; set; }    //stores name
        public string RPSValue { get; set; }  //stores value
        
        public Player(string Name)  //constructor so Rocky and Randy have a name on the console, but add to both R & R
        {
            this.Name = Name;
        }
        public abstract string GenerateRoShamBo();
    }
}
