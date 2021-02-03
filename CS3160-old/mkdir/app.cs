using System;
using Basketballplayer;

namespace MainApp
{
    public class App
    {
        public static void Main(string[] args)
        {
            Basketballplayer player;
            player = getPLayer();
            COnsole.WriteLine($"{player.fName} {player.lName}");


        }

        private static Basketballplayer getPLayer()
        {
            string fn, ln;
            Basketballplayer p;

            Console.WriteLine("Players First name: ");
            fn = Console.ReadLine();
            Console.WriteLine("Players Last name: ");
            ln = Console.ReadLine();

            p = new Basketballplayer();
            p.fName = fn;
            p.lName = ln;

            return p;
        }

    }//app
}//namespace