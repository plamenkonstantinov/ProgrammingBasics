using System;


namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());
            decimal price = 0.0m;
            if (numberOfPeople <= 4)
            {
                budget = 0.25m * budget;
            }
            else if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                budget = 0.4m * budget;
            }
            else if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                budget = 0.5m * budget;
            }
            else if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                budget = 0.6m * budget;
            }
            else
            {
                budget = 0.75m * budget;
            }
            if (category=="Normal")
            {
                price = 249.99m;
            }
            else
            {
                price = 499.99m;
            }
            if (budget>=price*numberOfPeople)
            {
                Console.WriteLine("Yes! You have {0} leva left.", budget-price*numberOfPeople);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.", price*numberOfPeople-budget);
            }
        }
    }
}
