using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }
        public override RPSEnum GetRPS()
        {
            Random rng = new Random();

            //Remember with random.next, min is inclusive max is exclusive 
            //0 will be rock 
            //1 will be paper 
            //2 will be scissors 

            int pick = rng.Next(0, 3);
            switch (pick)
            {
                case 0:
                    return RPSEnum.Rock;
                case 1:
                    return RPSEnum.Paper;
                case 2:
                    return RPSEnum.Scissors;
                default:
                    return RPSEnum.Rock;
            }
        }
    }
}
