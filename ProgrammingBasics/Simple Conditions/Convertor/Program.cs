using System;


namespace Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var curr1 = Console.ReadLine();
            var curr2 = Console.ReadLine();
            var mm = n * 1000;
            var cm = n * 100;
            var mi = n * 0.000621371192;
            var inc = n * 39.3700787;
            var km = n * 0.001;
            var ft = n * 3.2808399;
            var yd = n * 1.0936133;
            if (curr1 == "mm")
            {
                n = n / mm;
            }
            else if (curr1 == "cm")
            {
                n = n / cm;
            }
            else if (curr1 == "mi")
            {
                n = n / mi;
            }
            else if (curr1 == "in")
            {
                n = n / inc;
            }
            else if (curr1 == "km")
            {
                n = n / km;
            }
            else if (curr1 == "ft")
            {
                n = n / ft;
            }
            else if (curr1 == "yd")
            {
                n = n / yd;
            }
            if (curr2 == "mm")
            {
                n = n * mm;
            }
            if (curr2 == "cm")
            {
                n = n * cm;
            }
            if (curr2 == "mi")
            {
                n = n * mi;
            }
            if (curr2 == "in")
            {
                n = n * inc;
            }
            if (curr2 == "km")
            {
                n = n * km;
            }
            if (curr2 == "ft")
            {
                n = n * ft;
            }
            if (curr2 == "yd")
            {
                n = n * yd;
            }
            Console.WriteLine("{0} {1}", n, curr2);

        }
    }
}
