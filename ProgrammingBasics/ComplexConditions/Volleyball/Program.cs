using System;


namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {

            var year = Console.ReadLine();
            var p = int.Parse(Console.ReadLine());
            var h= int.Parse(Console.ReadLine());
            var sofiaweekends = 48 - h;
            decimal saturdaygames = sofiaweekends * 3.0m / 4.0m;
            decimal sundaygames = h;
            decimal holidaygames = p * 2.0m / 3.0m;
            decimal gamesinTotal = (saturdaygames + sundaygames + holidaygames);
            if (year=="leap")
            {
                Console.WriteLine(Math.Floor(gamesinTotal*1.15m));
            }
            else if (year =="normal")
            {
                Console.WriteLine(Math.Floor(gamesinTotal));
            }
        }
    }
}
