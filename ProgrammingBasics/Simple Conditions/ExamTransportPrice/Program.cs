using System;

class TransportPrice
{
    static void Main()
    {
        var distance = double.Parse(Console.ReadLine());
        var timeOfday = Console.ReadLine();
        var taxirate = 0.79;
        if (timeOfday == "night") 

        {
            taxirate = 0.9;
        }
        if (distance < 20)
        {
            Console.WriteLine(0.7 + distance * taxirate);
        }
        else if (distance < 100)
        {
            Console.WriteLine(distance * 0.09);
        }
        else
        {
            Console.WriteLine(distance * 0.06);
        }
    }
}
