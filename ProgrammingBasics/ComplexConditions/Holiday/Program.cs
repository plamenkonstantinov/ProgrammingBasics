using System;


namespace Holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget<=100)//Bulgaria
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season=="summer")
                {
                    Console.WriteLine("Camp - {0:f2}", (budget*0.3));
                }
                else if (season=="winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", (budget*0.7));
                }
            }
            else if (budget<=1000)//Balkans
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season=="summer")
                {
                    Console.WriteLine("Camp - {0:f2}", (budget*0.4));
                }
                else if (season=="winter")
                {
                    Console.WriteLine("Hotel - {0:f2}", (budget * 0.8));
                }
            }
            else //Europe
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", (budget * 0.9));
            }
        }
    }
}
