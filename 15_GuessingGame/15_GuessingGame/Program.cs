using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }


            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");

            }
            else
            {
                Console.WriteLine("You win!");

            }


            Console.ReadLine();
        }
    }
}
