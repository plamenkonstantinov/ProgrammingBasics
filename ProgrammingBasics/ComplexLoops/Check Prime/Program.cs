using System;


namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var prime = true;

            for (int divisor = 2; divisor < 2; divisor++)
            {
                if (n % divisor == 0)
                {
                    prime = false;
                    break;
                }

            }
            Console.WriteLine(prime);
        }
    }
}

