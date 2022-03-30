using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactWinnigPosition
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to snake Ladder Game");

            int position = 0;
            while (position < 100)
            {
                Random random = new Random();
                int Diceroll = random.Next(1, 7);
                if (position < 0)
                {
                    position = 0;
                }

                Console.WriteLine("Diceroll : " + Diceroll);



                Random randomcheck = new Random();
                int Checkoption = randomcheck.Next(0, 3);

                switch (Checkoption)
                {
                    case 0:
                        position = position;
                        Console.WriteLine("player statyed at position " + position);

                        break;
                    case 1:
                        position = position + Diceroll;
                        if (position > 100)
                        {
                            position = position - Diceroll;
                        }
                        Console.WriteLine("player moved to position " + position);
                        break;
                    case 2:
                        position = position - Diceroll;
                        Console.WriteLine("player back to position " + position);
                        break;

                }



            }

        }
    }
}
