using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();
        public int Draws { get; set; } = 0;

        //We leave this property blank since we want the user to select who they play
        public Player Opponent { get; set; }


        public RPSApp()
        {
            //Later on once we have randa, replace this line with code that 
            //Let's the player choose their opponent 
            while (true)
            {
                Console.WriteLine("Choose your Opponent: Human or Rock");
                string answer = Console.ReadLine();

                if(answer == "rocky" || answer == "rock")
                {
                    Opponent = new Rocky();
                    break;
                }
                else if(answer == "human")
                {
                    Console.WriteLine("Creating Player 2...");
                    Opponent = new UserPlayer();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I didn't understand that, lets try that again");
                    continue;
                }
            }
           

        }
        public Player Play()
        {
            RPSEnum p1 = Player.GetRPS();
            RPSEnum p2 = Opponent.GetRPS();
            Player winner = null;
            //This cuts out all the draw cases now we just have to worry about 
            //Wins/Loses
            if(p1 == p2)
            {
                Console.WriteLine("Draw!");
                Console.WriteLine("Both Players threw the same value");
                Draws++;
            }
            else if(p1 == RPSEnum.Rock)
            {
                if (p2 == RPSEnum.Paper)
                {
                    Console.WriteLine(Player.Name + " loses");
                    Console.WriteLine(Opponent.Name + " wins");
                }
            }
        }

    }
}
