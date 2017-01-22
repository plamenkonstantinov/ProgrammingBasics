using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("USD=");
            var USD = double.Parse(Console.ReadLine());
            var BGN = USD * 1.79549;
            Console.Write("BGN=");
            Console.WriteLine(Math.Round(BGN, 2));
        }
    }
}
