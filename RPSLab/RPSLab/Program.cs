using System;

namespace RPSLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rocky r = new Rocky();
            //Console.WriteLine(r.GetRPS());
            //UserPlayer p = new UserPlayer();
            //RPSEnum result = p.GetRPS();
            //Console.WriteLine(result);

            RPSApp app = new RPSApp();
            while (true)
            {
                app.Play();
                //Randa r = new Randa();
                //Console.WriteLine(r.GetRPS());
                //Console.ReadLine();
            }
        }
    }
}
