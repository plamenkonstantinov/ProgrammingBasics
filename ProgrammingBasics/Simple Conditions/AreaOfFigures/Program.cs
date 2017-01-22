using System;


namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {


            var type = Console.ReadLine();
            if (type == "square")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(a * a);
            }
            else if (type == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine(a * b);
            }
            else if (type == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(Math.PI * a * a, 3));
            }
            else if (type == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * h / 2, 3));
            }

        }
    }
}
