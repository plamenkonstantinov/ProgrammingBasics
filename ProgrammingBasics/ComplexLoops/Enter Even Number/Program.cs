﻿using System;


namespace Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            while (true)
            {
                Console.Write("Enter even numer:");
                n = int.Parse(Console.ReadLine());
                if (n%2==0)
                {
                    break;
                }
                Console.WriteLine("The number is not even");
            }
        }
    }
}
