using System;


namespace ExcellentOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}

