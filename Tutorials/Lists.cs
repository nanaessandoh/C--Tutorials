using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Lists
    {
        static void Main1(string[] args)
        {
            // Creating a List
            var names = new List<string> { "John", "Adam", "Stewart" };

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }


            // Adding and Removing
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Adam");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}.");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
            Console.WriteLine($"The list has {names.Count} people in it");

            // Searching
            var index = names.IndexOf("Maria");
            if (index != -1)
                Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");


            // Sorting
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }



            // Print the first 20 Fibonnaci Numbers
            var fibonacci = new List<int> { 1, 1 };

            for (int i = 0; i < 18; i++)
            {
                fibonacci.Add(fibonacci[i] + fibonacci[i + 1]);
            }

            foreach (var item in fibonacci)
                Console.WriteLine(item);


        }
    }
}
