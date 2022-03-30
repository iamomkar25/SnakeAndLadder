using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class RollDice
    {
        public const int Start = 0;
        public const int End = 100;
        static void Main(string[] args)
        {
            int currentPosition = 0;
            Console.WriteLine("Welcome to Snake and Ladder Problem!");
            Console.WriteLine("Starting position is : " + currentPosition);
            //Create Reference for Random class
            Random random = new Random();
            int numberOnDie = random.Next(1, 7);
            Console.WriteLine("Number on the die rolled is : " + numberOnDie);
        }
    }
}
