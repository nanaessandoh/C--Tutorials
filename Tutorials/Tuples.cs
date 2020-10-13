using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tutorials
{
    public class Tuples
    {
        public static void Main1()
        {
            var item = (Name: "Eggplant", Price: 1.99m , perPackage: 3 );
            var date = DateTime.Now;
            Console.WriteLine($"On {date}, the price of {item.Name} was {item.Price} per {item.perPackage} items.");
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
        }
    }

}
