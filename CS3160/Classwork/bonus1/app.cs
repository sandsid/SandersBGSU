using System;
using Player;

namespace MainApp
{
    public class App
    {
        public static void Main(string [] args)
        {
            
            BasketballPlayer player1, player2,player3;
            player1 = GetPlayer();
            player2 = GetPlayer();
            player3 = GetPlayer();
            
            //Get length of players
            //output players first, last name.
            Console.WriteLine($"\n{player1.firstN} {player1.lastN}\t [L = {player1.GetLength()}]");
            Console.WriteLine($"{player2.firstN} {player2.lastN}\t [L = {player2.GetLength()}]");
            Console.WriteLine($"{player3.firstN} {player3.lastN}\t [L = {player3.GetLength()}]");

        }

        private static BasketballPlayer GetPlayer()
        {
            string fname, lname;
            BasketballPlayer p;
            Console.Write("\nFirst name:\t");
            fname = Console.ReadLine();
            Console.Write("Last name:\t");
            lname = Console.ReadLine();

            p = new BasketballPlayer();
            p.firstN = fname;
            p.lastN = lname;
            return p;
        }
    }//class
}//namespace