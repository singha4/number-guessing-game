using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int h = 100, l = 0 , e, guess = 50;
            while (true)
            {

                guess = 50;
                Console.WriteLine("Is your guess higher, lower, or equal to {0}?", guess);

                input = Console.ReadLine();
                if (input == "h")
                {
                    guess = guess + 25;                   
                }
                else if (input == "l")
                {
                    guess = 25;
                }
            }
        }
    }
}
