using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var good = Console.ReadLine();
            var city = Console.ReadLine();
            var quantity = decimal.Parse(Console.ReadLine());
            var price = 0m;
            if (city=="Varna")//To do Varna, Plovdiv, Sofia
            {
                if (good=="coffee")
                {
                    price = quantity *0.45m;
                    
                }
                else if (good=="water")
                {
                    price = quantity * 0.7m;
                }
                else if (good=="beer")
                {
                    price = quantity * 1.1m;
                }
                else if (good=="sweets")
                {
                    price = quantity * 1.35m;
                }
                else if (good=="peanuts")
                {
                    price = quantity * 1.55m;
                }
            }
            else if (city=="Sofia")
            {
                if (good=="coffee")
                {
                    price = quantity * 0.5m;
                }
                else if (good=="water")
                {
                    price = quantity * 0.8m;
                }
                else if (good=="beer")
                {
                    price = quantity * 1.2m;
                }
                else if (good=="sweets")
                {
                    price = quantity * 1.45m;
                }
                else if (good=="peanuts")
                {
                    price = quantity * 1.6m;
                }
            }
            else if (city=="Plovdiv")
            {
                if (good=="coffee")
                {
                    price = quantity * 0.4m;
                }
                else if (good=="water")
                {
                    price = quantity * 0.7m;
                }
                else if (good=="beer")
                {
                    price = quantity * 1.15m;
                }
                else if (good=="sweets")
                {
                    price = quantity * 1.3m;
                }
                else if (good=="peanuts")
                {
                    price = quantity * 1.5m;
                }
            }
            {
                Console.WriteLine(price);      
            }
        }
    }
}
