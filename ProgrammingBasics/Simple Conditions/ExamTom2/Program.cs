using System;


namespace ExamTom2
{
    class Program
    {
        static void Main(string[] args)
        {
            var holidays = int.Parse(Console.ReadLine());
            var workingdays = 365 - holidays;
            var totalplaytime = (holidays * 127) + (workingdays * 63);
            var difference = 30000 - totalplaytime;
            var hours = Math.Abs(difference / 60);
            var minutes = Math.Abs(difference % 60);
            if (totalplaytime>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minutes);
            }

        }
    }
}
