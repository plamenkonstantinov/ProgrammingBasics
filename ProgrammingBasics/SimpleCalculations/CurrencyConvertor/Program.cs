using System;

namespace CurrencyConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Value:");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.Write("Currency1:");
            string currency1 = Console.ReadLine();
            Console.Write("Currency2:");
            string currency2 = Console.ReadLine();
            decimal value1 = 0.0m;
            decimal value2 = 0.0m;
            if (currency1 == "BGN")
            { value1 = 1; }
            else if (currency1 == "USD")
            { value1 = 1.79549m; }
            else if (currency1 == "EUR")
            { value1 = 1.95583m; }
            else if (currency1 == "GBP")
            { value1 = 2.53405m; }
            if (currency2 == "BGN")
            { value2 = 1; }
            else if (currency2 == "USD")
            { value2 = 1.79549m; }
            else if (currency2 == "EUR")
            { value2 = 1.95583m; }
            else if (currency2 == "GBP")
            { value2 = 2.53405m; }
            Console.Write("Converted value:");
            decimal Result = number * (value1 / value2);
            Console.WriteLine(Math.Round(Result, 2));
        }
    }
}