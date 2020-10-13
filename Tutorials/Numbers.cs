using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    class Numbers
    {
        static void Main1(string[] args)
        {
            int a = 18;
            int b = 6;

            // Addition
            int c = a + b;
            Console.WriteLine(c);
            // Subtraction
            c = a - b;
            Console.WriteLine(c);
            // Multiplication
            c = a * b;
            Console.WriteLine(c);


            // Order of Operations is ().M/D.A/
            int e = 5;
            int f = 4;
            int g = 2;
            int h = e + f * g;
            Console.WriteLine(h);

            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            // Quotient and Remainder
            int aa = 7;
            int bb = 4;
            int cc = 3;
            int dd = (aa + bb) / cc;
            int ee = (aa + bb) % cc;
            Console.WriteLine($"quotient: {dd}");
            Console.WriteLine($"remainder: {ee}");

            // Maximum and Minimun for int
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            // Overflow
            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");

            // Doubles
            double aq = 5;
            double bq = 4;
            double cq = 2;
            double dq = (aq + bq) / cq;
            Console.WriteLine(dq);

            // Maximum and Minimum for double 
            double maxd = double.MaxValue;
            double mind = double.MinValue;
            Console.WriteLine($"The range of double is {mind} to {maxd}");


            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            // Decimal
            decimal mina = decimal.MinValue;
            decimal maxa = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {mina} to {maxa}");

            // Testing the Range
            double az = 1.0;
            double bz = 3.0;
            Console.WriteLine(az / bz);

            decimal cz = 1.0M;
            decimal dz = 3.0M;
            Console.WriteLine(cz / dz);

            // Calcuate the Area of a circle
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle is {area}");
        }
    }
}
