using System;


namespace ExamTom
{
    class Program
    {
        static void Main(string[] args)
        {

            int holidays = int.Parse(Console.ReadLine());
            var workingdays = 365 - holidays;
            var totalplay = (63 * workingdays) + (127 * holidays);
            if (totalplay > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (totalplay - 30000) / 60, (totalplay - 30000) % 60);
                
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes more for play", (30000 - totalplay) / 60, (30000 - totalplay) % 60);
            }

        }
    }
}
