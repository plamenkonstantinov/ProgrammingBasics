using System;


namespace ExamPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var pool = (p1 + p2)*h;
                        if (pool<=v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",Math.Truncate(pool/v*100) ,Math.Truncate(p1*h/pool*100) , Math.Truncate(p2 * h / pool * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, pool-v );
            }
        }
    }
}
