using System;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integers:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Greater number:{0}", num1);

            }
            else
            {
                Console.WriteLine("Greater number:{0}", num2);

            }
        }
    }
}
