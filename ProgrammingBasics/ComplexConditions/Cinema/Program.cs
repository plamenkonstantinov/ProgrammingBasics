using System;


namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var row = int.Parse(Console.ReadLine());
            var collumn = int.Parse(Console.ReadLine());
            if (type=="Premiere")
            {
                Console.WriteLine("{0:f2}", (collumn*row*12));
            }
            else if (type=="Normal")
            {
                Console.WriteLine("{0:f2}", (collumn * row * 7.5));
            }
            else if (type =="Discount")
            {
                Console.WriteLine("{0:f2}", (collumn * row * 5));
            }
        }
    }
}
