using System;


namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = double.Parse(Console.ReadLine());
            var O = double.Parse(Console.ReadLine());
            var area = 2 * N;
            var tile = W * L;
            var seat = M * O;
            var areaTocover = area - seat;
            Console.WriteLine(area);
       
        }
    }
}
