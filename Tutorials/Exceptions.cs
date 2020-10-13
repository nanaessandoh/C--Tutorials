using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class Exceptions
    {

        private static bool LogException(Exception e)
        {
            Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
            Console.WriteLine($"\tMessage: {e.Message}");
            return false;
        }

        public static void Main1(string[] args)
        {
            try
            {
                string s = null;
                Console.WriteLine(s.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Exception must have been handled");
        }
    }
}
