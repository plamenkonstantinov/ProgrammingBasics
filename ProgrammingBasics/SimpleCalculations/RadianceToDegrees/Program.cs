using System;

namespace RadianceToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Radiance=");
            var radiance = double.Parse(Console.ReadLine());
            Console.Write("Degree=");
            var degree = radiance * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree, 0));
        }
    }
}
