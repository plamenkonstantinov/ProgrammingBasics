using System;


namespace ExamFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeneeded = int.Parse(Console.ReadLine());
            var deadline = int.Parse(Console.ReadLine());
            var workersovertime = int.Parse(Console.ReadLine());
            var availabledays = deadline * 0.9;
            var overtime = workersovertime * 2 * deadline;
            var totalWorkhours = Math.Floor(availabledays * 8 + overtime);
            var difference = totalWorkhours - timeneeded;
            if (totalWorkhours>=timeneeded)
            {
                Console.WriteLine("Yes!{0} hours left.",difference );
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(difference));
            }
        }
    }
}
