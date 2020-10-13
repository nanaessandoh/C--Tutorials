using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class GuessGame
    {
        static void Main1(string[] args)
        {

            string myInput = string.Empty;
            string GuessWord = "Ghana";
            int CurrentAttempt = 0;
            int AttemptLimit = 3;
            while (GuessWord != myInput && CurrentAttempt != AttemptLimit)
            {
                Console.Write($"Guess the Secret Word: ");
                myInput = Console.ReadLine();
                CurrentAttempt++;
            }
            if (GuessWord == myInput)
                Console.WriteLine("You Win");
            else 
                Console.WriteLine("You Lose");


            Console.ReadLine();
        }
    }
}
