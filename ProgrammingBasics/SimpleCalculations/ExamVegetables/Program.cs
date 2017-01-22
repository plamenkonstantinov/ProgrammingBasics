using System;

namespace ExamVegetables
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegPrice = double.Parse(Console.ReadLine());
            var fruPrice = double.Parse(Console.ReadLine());
            var vegWeight = double.Parse(Console.ReadLine());
            var fruWeight = double.Parse(Console.ReadLine());
            var vegincome = vegPrice * vegWeight ;
            var fruincome = fruPrice * fruWeight ;
            var totalIncome = (vegincome + fruincome)/1.94 ;
            Console.WriteLine(totalIncome);

        }
    }
}
