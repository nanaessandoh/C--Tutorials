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

        public static void Main10(string[] args)
        {
            try
            {
                string s = null;
                Console.WriteLine(s.Length);

            }
            catch (Exception e) when (LogException(e))
            {
            }
            Console.WriteLine("Exception must have been handled");
        }
    }
}
