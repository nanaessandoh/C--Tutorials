using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Recursion
    {

        static int Factorial (int number)
        {
            if (number == 1)
                return 1;
            else
                return number * Factorial(number - 1);

        }


        static void Main1(string[] args)
        {
            //= 1
            //= 2 * Factorial(1)
            //= 3 * Factorial(2)
            //= 4 * Factorial (3)
            //Final = 4*3*2*1
            Console.WriteLine(Factorial(4));
        }
    }
}
