using System;



namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());

            double foodForDogKg = double.Parse(Console.ReadLine());
            double foodForCatKg = double.Parse(Console.ReadLine());
            double foodForTurtleG = double.Parse(Console.ReadLine());

            double foodForTurtleKg = foodForTurtleG / 1000.0;
            var totalFoodNeeded = (foodForTurtleKg + foodForDogKg + foodForCatKg)*days;
            
            if (totalFoodNeeded>foodLeft)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalFoodNeeded-foodLeft));
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft-totalFoodNeeded));
            }
        }
    }
}
