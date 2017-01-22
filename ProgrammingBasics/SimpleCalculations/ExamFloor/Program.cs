using System;


namespace ExamFloor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var l = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var o = double.Parse(Console.ReadLine());
            var area = n * n;
            var areatile = w * l;
            var areaTocover = area - (m * o);
            var tilesneeded = areaTocover / areatile;
            var timeneeded = tilesneeded*0.2;
            Console.WriteLine(tilesneeded);
            Console.WriteLine(timeneeded);
        }
    }
}
