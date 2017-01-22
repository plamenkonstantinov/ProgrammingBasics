using System;


namespace Hrvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerSqMeter = double.Parse(Console.ReadLine());
            int litersWineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var wine = (area*grapePerSqMeter)*0.4/2.5;

           
            if (wine<litersWineNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(litersWineNeeded-wine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(wine - litersWineNeeded), Math.Ceiling((wine-litersWineNeeded)/workers));
            }
        }
    }
}
