using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class ReverseInteger
    {
        public static int ReverseMyInt(int Input)
        {
            int reverse = 0;
            while (Input > 0)
            {
                int remainder = Input % 10;
                reverse = (reverse * 10) + remainder;
                Input = Input / 10;
            }
            return reverse;
        }

        public static void Main1(string[] args)
        {
            Console.Write($"Please Enter an Integer: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"The reverse integer is : {ReverseMyInt(input)}");

        }

    }
}
