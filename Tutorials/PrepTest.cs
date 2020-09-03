using System;
using System.Collections.Generic;
using System.Linq;

namespace Tutorials
{
    public class PrepTest
    {
        // Show distinct value in a list
        public static List<int> ShowUniqueValues( List<int> InputArray)
        {
            var distinctArray = InputArray.Distinct();

            return distinctArray.OfType<int>().ToList();
        }

        // Count distinct pairs in a List
        public static int CountUniquePairs(List<int> inputList)
        {
            int count = 0;
            // Sort the List
            inputList.Sort();

            //Get the length of the array
            int listCount = inputList.Count;

            if (inputList[0] != inputList[listCount - 1])
            {
                count++;
            }

            for (int i = 0; i < listCount - 1; i++)
            {
                if (inputList[i] != inputList[i + 1])
                    count++;
            }

            return count;
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
            string sentence = string.Empty;
            string[] reverseSentence = input.Split(' ');
            Array.Reverse(reverseSentence);

            foreach( string x in reverseSentence)
            {
                sentence += $"{x} ";
            }

            return sentence;
        }

        // Maximum value of a List
        public static int MaximumValue( List<int> input)
        {
            input.Sort();
            return input[input.Count - 1];
        }

        // Minimum value of List
        public static int MinimumValue(List<int> input)
        {
            input.Sort();
            return input[0];
        }

        // Remainder
        public static int Remainder(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        // Distinct Value and their frequency
        public static string DistinctValueAndFrequency(List<int> input)
        {
            int count;
            string output = string.Empty;
            var distinctArray = input.Distinct();

            foreach ( int x in distinctArray)
            {
                count = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    if(x == input[i])
                    {
                        count++;
                    }
                }

                output += $"{x}({count}) ";
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
        public static void Main11()
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

            Console.Write($"\n\n\n");
        }
    }
}
