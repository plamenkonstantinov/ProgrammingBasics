using System;

namespace C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("C=");
            var C = double.Parse(Console.ReadLine());
            var F = C * 1.8 + 32;
            Console.Write("F =");
            Console.WriteLine(Math.Round(F, 2));

        }
    }
}
