using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Tutorials
{
    public class Vegetable
    {
        public string Name{get; }
        public Vegetable(string name) => Name = name;

        public override string ToString() => Name;
    }

    public class Program1 
    {
        public enum Unit { item, kilogram, gram, dozen };
        public static void Main1() 
        {
            var item = new Vegetable ("Eggplant");
            var date = DateTime.Now;
            var price = 1.99m;
            var unit = Unit.item;
            Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
        }

    }
}
