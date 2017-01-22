using System;


namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());
            var commission = -1.0;
            if (city=="Sofia")
            {
                if (sales>=0&&sales<=500)
                {
                    commission = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.08;
                }
                else if (sales >10000)
                {
                    commission = 0.12;
                }
            }
            else if (city=="Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.1;
                }
                else if (sales > 10000)
                {
                    commission = 0.13;
                }

            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    commission = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    commission = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    commission = 0.12;
                }
                else if (sales > 10000)
                {
                    commission = 0.145;
                }
            }

            if (commission>=0)
            {
                Console.WriteLine("{0:f2}" , (commission * sales));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
