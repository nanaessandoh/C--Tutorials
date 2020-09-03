using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class IfElse
    {
        static void Main3(string[] args)
        {
            // IF
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

            // IF/ELSE
            int c = 3;
            int d = 6;
            if (c + d > 10)
                Console.WriteLine("The answer is greater than 10.");

            // IF/ELSE with no brances
            int e = 5;
            int f = 3;
            if (e + f > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            // IF/ELSE with braces and more conditions
            int g = 5;
            int h = 3;
            int i = 4;
            if ((g + h + i > 10) && (g == h))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("The first number is not equal to the second");
            }

            // IF/ELSE with braces and more conditions
            int j = 5;
            int k = 3;
            int l = 4;
            if ((j + k + l > 10) || (j == k))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }
    }
}
