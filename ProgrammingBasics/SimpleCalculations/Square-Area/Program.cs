﻿using System;


namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = int.Parse(Console.ReadLine());
            var area = a * a;
            Console.Write("Square=");
            Console.WriteLine(a * a);
        }
    }
}
