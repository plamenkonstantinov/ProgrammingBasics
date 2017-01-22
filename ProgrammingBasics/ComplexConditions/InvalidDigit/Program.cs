using System;


namespace InvalidDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var inRange = (n >= 100 && n <= 200 || n == 0);
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
