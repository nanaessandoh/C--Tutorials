using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class Dictionary
    {
        public static void Main11()
        {
            var messages = new Dictionary<int, string>
            {
                [101] = "Page not Found",
                [102] = "Page moved, but left with a forwarding address",
                [103] = "The web server cant come to play today"
            };

            Console.WriteLine(messages[102]);

            var inventory = new Dictionary<string, int>()
            {
                ["hammer, ball pein"] = 18,
                ["hammer, cross pein"] = 3,
                ["screwdriver, Phillips #2"] = 14
            };

            Console.WriteLine($"Inventory on {DateTime.Now:d}");
            Console.WriteLine(" ");
            Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            foreach (var item in inventory)
                Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");

      

        }
    }
}
