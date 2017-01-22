using System;


namespace ExamClassroom
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
             h = h * 100;
            w = w * 100 - 100;
            var rows = Math.Floor(h / 120);
            var desks = Math.Floor(w / 70);
            var places = rows * desks - 3;
            Console.WriteLine(places);

        }
    }
}
