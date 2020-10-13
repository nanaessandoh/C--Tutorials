using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Loops
    {
        static void Main1(string[] args)
        {
            // While Condition
            int counter1 = 0;
            while (counter1 < 10)
            {
                Console.WriteLine($"Hello! The counter is {counter1}");
                counter1++;
            }

            // Do..While Condition
            int counter2 = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter2}");
                counter2++;
            } while (counter2 < 10);


            // For loop
            for (int counter3 = 0; counter3 < 10; counter3++)
            {
                Console.WriteLine($"Hello Guys! The counter is {counter3}");
            }


            // Nested Loops
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }


            // write C# code to find the sum of all integers 1 through 20 that are divisible by 3
            int sum = 0;
            for (int number = 1; number <= 20; number++)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
