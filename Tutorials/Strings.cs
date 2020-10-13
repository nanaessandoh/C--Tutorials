using System;

namespace Tutorials
{
    class Strings
    {
        static void Main1(string[] args)
        {

            // Legacy Hello World
            Console.WriteLine("Hello World!");

            // Using Consol.Writeline to output strings
            string aFriend = "Bill";
            Console.WriteLine("Hello " + aFriend);
            Console.WriteLine($"Hello {aFriend}");

            string firstFriend = "Maria";
            string secondFriend = "Sage";

            // Experimenting other string functionalities 
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters and {secondFriend} has {secondFriend.Length} letters.");

            // Removing whitespace from strings
            string greeting = "           Hello World!       ";
            Console.WriteLine($"*{greeting}*");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"*{trimmedGreeting}*");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"*{trimmedGreeting}*");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"*{trimmedGreeting}*");


            // Replacing Substrings in a String
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // Upper and Lowercase
            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            // Search a string to see if it contains a Substring
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // Confirm if a string starts or ends with a substring
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

        }
    }
}
