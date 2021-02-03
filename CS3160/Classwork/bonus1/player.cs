using System;
namespace Player
{
    public class BasketballPlayer 
    {
        public string firstN;
        public string lastN;

        public int GetLength()
        {
            return this.firstN.Length + this.lastN.Length;
        }

    }//class
}//namespace