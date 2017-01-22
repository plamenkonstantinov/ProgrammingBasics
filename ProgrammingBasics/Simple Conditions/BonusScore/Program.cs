using System;


namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var bonusScore = 0.0;
            var bonusScore2 = 0.0;
            if (number <= 100)
            {
                bonusScore = 5;
            }

            else if (number <= 1000)
            {
                bonusScore = number * 0.2;
            }
            else if (number > 1000)
            {
                bonusScore = number * 0.1;
            }
            if (number % 2 == 0)
            {
                bonusScore2 = 1;
            }
            if (number % 10 == 5)
            {
                bonusScore2 = 2;

            }
            var bonus = bonusScore2 + bonusScore;
            Console.WriteLine(bonus);
            var result = number + bonus;
            Console.WriteLine(result);
        }
    }
}
