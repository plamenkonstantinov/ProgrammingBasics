using System;


class Fruit_Shop
{
    static void Main()
    {
        string fruit = Console.ReadLine();
        string dayOfWeek = Console.ReadLine();
        decimal amount = decimal.Parse(Console.ReadLine());
        decimal bananaPrice = 2.50M;
        decimal applePrice = 1.20M;
        decimal orangePrice = 0.85M;
        decimal grapefruitPrice = 1.45M;
        decimal kiwiPrice = 2.70M;
        decimal pineapplePrice = 5.50M;
        decimal grapesPrice = 3.85M;

        if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
        {
            switch (fruit)
            {
                case "banana":
                    Console.WriteLine("{0:F2}", bananaPrice * amount);
                    break;
                case "apple":
                    Console.WriteLine("{0:F2}", applePrice * amount);
                    break;
                case "orange":
                    Console.WriteLine("{0:F2}", orangePrice * amount);
                    break;
                case "grapefruit":
                    Console.WriteLine("{0:F2}", grapefruitPrice * amount);
                    break;
                case "kiwi":
                    Console.WriteLine("{0:F2}", kiwiPrice * amount);
                    break;
                case "pineapple":
                    Console.WriteLine("{0:F2}", pineapplePrice * amount);
                    break;
                case "grapes":
                    Console.WriteLine("{0:F2}", grapesPrice * amount);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
        {
            switch (fruit)
            {
                case "banana":
                    Console.WriteLine("{0:F2}", (bananaPrice + 0.20M) * amount);
                    break;
                case "apple":
                    Console.WriteLine("{0:F2}", (applePrice + 0.05M) * amount);
                    break;
                case "orange":
                    Console.WriteLine("{0:F2}", (orangePrice + 0.05M) * amount);
                    break;
                case "grapefruit":
                    Console.WriteLine("{0:F2}", (grapefruitPrice + 0.15M) * amount);
                    break;
                case "kiwi":
                    Console.WriteLine("{0:F2}", (kiwiPrice + 0.30M) * amount);
                    break;
                case "pineapple":
                    Console.WriteLine("{0:F2}", (pineapplePrice + 0.10M) * amount);
                    break;
                case "grapes":
                    Console.WriteLine("{0:F2}", (grapesPrice + 0.35M) * amount);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}