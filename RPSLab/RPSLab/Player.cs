using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    abstract class Player
    {
        public string Name { get; set; }
        public RPSEnum RPS { get; set; }

        //This forces our children to make their own version of that method
        public abstract RPSEnum GetRPS();
    }
}
