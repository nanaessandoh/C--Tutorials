using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Tutorials
{
    public class PrepTest
    {
        // Show distinct value in a list
        public static List<int> ShowUniqueValues( List<int> InputArray)
        {
            var distinctArray = InputArray.Distinct();

            return distinctArray.ToList();
        }

        // Count distinct pairs in a List
        public static int CountUniquePairs(List<int> inputList)
        {
            return inputList.Distinct().Count();
        }

        // Reverse a string
        public static string ReverseMyInput(string Input)
        {
            char[] temp = Input.ToCharArray();
            Array.Reverse(temp);
            return new string(temp);
        }

        // Reverse a sentence
        public static string ReverseSentence(string input)
        {
            string[] reverseSentence = input.Split(" ");
            Array.Reverse(reverseSentence);
            return string.Join(" ",reverseSentence);
        }

        // Maximum value of a List
        public static int MaximumValue( List<int> input)
        {
            //input.Sort();
            //return input[input.Count - 1];
            return input.Max();
        }

        // Minimum value of List
        public static int MinimumValue(List<int> input)
        {
            //input.Sort();
            //return input[0];
            return input.Min();
        }

        // Remainder
        public static int Remainder(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        // Distinct Value and their frequency
        public static string DistinctValueAndFrequency(List<int> input)
        {
            string output = string.Empty;
            var distinctArray = input.Distinct();

            foreach ( int x in distinctArray)
            {
                int count = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    if(x == input[i])
                    {
                        count++;
                    }
                }

                output += $"Value:{x} Freq:{count}\n";
            }

            return output;
        }

        // Reverse an Integer
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

        // FizzBuzz
        public static void Fizbuzz(int IterNum)
        {
            for (int i = 1; i <= IterNum; i++ )
            {
                string output = string.Empty;
                if (i % 3 == 0)
                    output += "Fizz";
                if (i % 5 == 0)
                    output += "Buzz";
                if (String.IsNullOrEmpty(output))
                    output += i.ToString();
                Console.WriteLine(output);
            }

        }


        static double AngleBetweenHourMinute(int hour, int min)
        {
            double m = (360 / 60) * min;
            double h = ((360 / 12)* hour) + ((360 / 12) * (min / 60.0));
            double deg = Math.Abs(m - h);

            return Math.Min(deg, 360-deg);

        }


        static string FirstRecuringChar(string input)
        {
            var dict = new HashSet<char>();
            foreach (char item in input)
            {
                if (dict.Contains(item))
                {
                    return item.ToString();
                }
                else
                    dict.Add(item);
            }

            return "None";
        }
        public static void Main()
        {

            List<int> myList = new List<int>() { 1, 2, 3, 4, 4, 2, 3, 5 };
            List<int> mySortList = new List<int>() { 1, 1, 3, 7, 2, 2, 4, 10, 15, 2, 4, 6, 4 };
            string input = "Reverse";
            string sentence = "The dog is my hero";
            int myNumber = 12413456;

            // Show the Distinct Values
            Console.Write($"The distinct values are: ");
            var item = ShowUniqueValues(myList);

            foreach (var asset in item)
            {
                Console.Write($"{asset} ");
            }

            // Count unique pairs in a List
            Console.WriteLine($"\nCount unique pair: {CountUniquePairs(myList)}");

            // Reverse a string
            Console.WriteLine($"The reverse string : {ReverseMyInput(input)}");

            // Reverse a sentence
            Console.WriteLine($"The reverse sentence : {ReverseSentence(sentence)}");

            // Maximum Value of a List
            Console.WriteLine($"Maximum Value in a list : {MaximumValue(mySortList)}");

            // Minimum Value of a List
            Console.WriteLine($"Minimum value in a list : {MinimumValue(mySortList)}");

            // Distinct values and frequncy
            Console.WriteLine($"Distinct values and frequency : {DistinctValueAndFrequency(mySortList)}");

            // Reverse Integer
            Console.WriteLine($"The reverse integer is : {ReverseMyInt(myNumber)}");

            // Test FizzBuzz
            Fizbuzz(20);

            // Test Angle between hour and minute
            int hour = 2, minute = 10;

            Console.WriteLine($"The angle between {hour} and {minute} is {AngleBetweenHourMinute(hour, minute)}");

            Console.Write($"\n\n\n");


            char a = 'a';

            int num = Convert.ToInt32(a -'a');
            Console.WriteLine(num);
            /* 
             
             
             */
        }
    }
}
