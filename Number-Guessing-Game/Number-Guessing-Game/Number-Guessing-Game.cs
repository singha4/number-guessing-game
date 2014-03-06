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
            int high = 100, low = 0 , e, guess;
            while (true)
            {
                guess = (high + low) / 2;
                Console.WriteLine("Is your guess higher, lower, or equal to {0}?", guess);
                input = Console.ReadLine();
                if (input == "h")
                {
                    low = guess + 1;
                }
                else if (input == "l")
                {
                    high = guess - 1;   
                    
                }
                else if (input == "e")
                {
                    break;
                }
            }
        }
    }
}
