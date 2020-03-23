using System;

namespace _3.__Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            double aa, bb, cc, dd;
            decimal Mc, Md;

            // Explore integer math

            a = 18;
            b = 6;

            c = a + b;
            Console.WriteLine(c);
            
            c = a - b;
            Console.WriteLine(c);
            
            c = a * b;
            Console.WriteLine(c); 
            
            c = a / b;
            Console.WriteLine(c);



            // Explore order of operations

            a = 5;
            b = 4;
            c = 2;
            d = a + b * c;
            Console.WriteLine(d);

            a = 5;
            b = 4;
            c = 2;
            d = (a + b) * c;
            Console.WriteLine(d);

            a = 5;
            b = 4;
            c = 2;
            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            Console.WriteLine(d);



            // Explore integer precision and limits

            a = 7;
            b = 4;
            c = 3;
            d = (a + b) / c;
            e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");



            // Work with the double type

            aa = 5;
            bb = 4;
            cc = 2;
            dd = (aa + bb) / cc;
            Console.WriteLine(dd);

            aa = 19;
            bb = 23;
            cc = 8;
            dd = (aa + bb) / cc;
            Console.WriteLine(dd);

            double maxmax = double.MaxValue;
            double minmin = double.MinValue;
            Console.WriteLine($"The range of double is {minmin} to {maxmax}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);



            // Work with fixed point types

            decimal Mmin = decimal.MinValue;
            decimal Mmax = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {Mmin} to {Mmax}");

            aa = 1.0;
            bb = 3.0;
            Console.WriteLine(aa / bb);

            Mc = 1.0M;
            Md = 3.0M;
            Console.WriteLine(Mc / Md);

            /* Challenge
             * Now that you've seen the different numeric types, write code that calculates the area of a circle whose radius is 2.50 centimeters.
             * Remember that the area of a circle is the radius squared multiplied by PI. One hint: .NET contains a constant for PI, Math.PI that you can use for that value. */
            
            double Area, Radius;
            Radius = 2.5;
            Area = Math.PI * Radius * Radius;
            Console.WriteLine("Area of Ciccle with radius 2.5cm " + Area);
        }
    }
}
 