using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
        }

        //We want our user to select R P or S 
        //and if we get anything else, ask for an RPS value again 
        public override RPSEnum GetRPS()
        {
            Console.WriteLine("Please select rock paper or scissors (Or r p or s for short)");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "rock":
                    return RPSEnum.Rock;
                case "r":
                    return RPSEnum.Rock;
                case "paper":
                    return RPSEnum.Paper;
                case "p":
                    return RPSEnum.Paper;
                case "scissors":
                    return RPSEnum.Scissors;
                case "s":
                    return RPSEnum.Scissors;
                default:
                    Console.WriteLine("I'm sorry I don't understand your input lets try again");
                    return GetRPS();
            }
        }
    }
}
