using System;


namespace ExamWine
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = double.Parse(Console.ReadLine());
            var grapePersqm = double.Parse(Console.ReadLine());
            var wineneeded = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var totalwine = 0.4 * area* grapePersqm/2.5;
            var difference = totalwine - wineneeded;
            var remainder = Math.Abs(difference);
            var wineperperson = Math.Truncate(difference / workers);
            if (totalwine>=wineneeded)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", totalwine);
                Console.WriteLine("{0} liters left -> {1} liters per person.", difference, wineperperson);
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Truncate(remainder));
            }


        }
    }
}
