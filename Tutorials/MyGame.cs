using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class MyGame
    {

        
        public static void Main1(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            

        }


        static bool MainMenu()
        {
            Console.WriteLine("Choose and option");
            Console.WriteLine("1) Guessing Game");
            Console.WriteLine("2) Game 2");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();
            if(result == "1")
            {
                return true;
            }
            else if(result == "2")
            {
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
