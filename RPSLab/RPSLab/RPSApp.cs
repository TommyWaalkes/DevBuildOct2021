using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLab
{
    class RPSApp
    {
        public UserPlayer Player { get; set; } = new UserPlayer();
        public int Draws { get; set; } = 0;
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0; 

        //We leave this property blank since we want the user to select who they play
        public Player Opponent { get; set; }


        public RPSApp()
        {
            //Later on once we have randa, replace this line with code that 
            //Let's the player choose their opponent 
            while (true)
            {
                Console.WriteLine("Choose your Opponent: Human, Rock, or Randa");
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
                else if(answer == "randa")
                {
                    Opponent = new Randa();
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry I didn't understand that, lets try that again");
                    continue;
                }
            }
           

        }
        public void Play()
        {
            RPSEnum p1 = Player.GetRPS();
            RPSEnum p2 = Opponent.GetRPS();
            Console.WriteLine();
            Console.WriteLine("New Round");
            Console.WriteLine();
            Console.WriteLine($"{Player.Name} throws: {p1}");
            Console.WriteLine($"{Opponent.Name} throws {p2}");
            //this bool if true, p1 is the winner, if false p1 loses, but if its null, it is a draw
            //What does that ? mean on bool? 
            //? means that nulls will be allowed in that variable, IE it makes it nullable 
            //This is useful for when you have a datatype that otherwise doesn't allow null values 
            //Example Data Types: bool, ints, doubles, and chars 
            //Most object data types allow nulls by default

            bool? p1Wins = null;
            //This cuts out all the draw cases now we just have to worry about 
            //Wins/Loses
            if(p1 == p2)
            {
                Console.WriteLine("Draw!");
            }
            else if(p1 == RPSEnum.Rock)
            {
                //Since we checked for draws, we now only need to check for wins and losses
                if (p2 == RPSEnum.Paper)
                {
                    p1Wins = false;
                }
                else if(p2 == RPSEnum.Scissors)
                {
                    p1Wins = true;
                }
            }
            else if(p1 == RPSEnum.Paper)
            {
                if(p2 == RPSEnum.Rock)
                {
                    p1Wins = true;
                }
                else if(p2 == RPSEnum.Scissors)
                {
                    p1Wins = false;
                }
            }
            else if(p1 == RPSEnum.Scissors)
            {
                if(p2 == RPSEnum.Paper)
                {
                    p1Wins = true;
                }
                else if(p2 == RPSEnum.Rock)
                {
                    p1Wins = false;
                }
            }

            if (p1Wins == true)
            {
                Console.WriteLine(Player.Name + " wins!");
                Console.WriteLine(Opponent.Name + " loses!");
                Wins++;

            }
            else if (p1Wins == false)
            {
                Console.WriteLine(Player.Name + " loses!");
                Console.WriteLine(Opponent.Name + " wins!");
                Losses++;
            }
            else if(p1Wins == null)
            {
                Console.WriteLine("Draw!");
                Console.WriteLine("Both Players threw the same value");
                Draws++;
            }

            PrintRecord();
        }

        public void PrintRecord()
        {
            Console.WriteLine($"Match Between {Player.Name} and {Opponent.Name}");
            Console.WriteLine($"Wins: {Wins}");
            Console.WriteLine($"Losses: {Losses}");
            Console.WriteLine($"Draws: {Draws}");
            Console.WriteLine();
        }

    }
}
