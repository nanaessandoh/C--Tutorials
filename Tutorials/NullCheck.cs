using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class NullCheck
    {

        static void Main1(string[] args) 
        {
            string t = null;
            Console.WriteLine(t?.Length);


            char? c = t?[0];
            Console.WriteLine(c.HasValue);

            string s = null;
            bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext();
            Console.WriteLine(hasMore.HasValue && hasMore.Value);

            bool hasMoree = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
            Console.WriteLine(hasMoree);
        }
    }
}