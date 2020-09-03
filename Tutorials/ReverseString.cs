using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorials
{
    public class ReverseString
    {

        public static string ReverseMyInput1( string Input)
        {
            // Declare empty string and get the length of input string
            string reverse = "";
            int length = Input.Length - 1;

            // Loop through input from the last character and assign to the empty string 
            while (length >= 0)
            {
                reverse = $"{reverse}{Input[length]}";
                length--;
            }

            return reverse;
        }

        public static string ReverseMyInput2(string Input)
        {
            char[] temp = Input.ToCharArray();
            Array.Reverse(temp);
            return new string (temp);
        }

        public static void Main8(string[] args)
        {
            Console.Write($"Please Enter a String: ");
            string input = Console.ReadLine();
            Console.WriteLine($"The reverse string Implementaion 1 : {ReverseMyInput1(input)}");
            Console.WriteLine($"The reverse string Implementaion 2 : {ReverseMyInput2(input)}");

        }
    }
}
