using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorials
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; } = "";
        public string LastName { get; private set; }

        public Person(string First, string Middle, string Last)
        {
            FirstName = First;
            MiddleName = Middle;
            LastName = Last;
        }

        public override string ToString() => FirstName + " " + LastName;
        

        public string AllCaps() => ToString().ToUpper();
    }


    public class Program
    {
        static void Main6(string[] args)
        {
            var Test = new Person("John", "", "Lampard");
            Console.WriteLine($"The name, in all caps: {Test.AllCaps()}");
            Console.WriteLine($"The name: {Test}");

            var phrase = "the quick brown fox jumps over the lazy dog";
            var wordLength = from word in phrase.Split(' ') select word.Length;
            var average = wordLength.Average();
            Console.WriteLine(average);
        }
    }
}
